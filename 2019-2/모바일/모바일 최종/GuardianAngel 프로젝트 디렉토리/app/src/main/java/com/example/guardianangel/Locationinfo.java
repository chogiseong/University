package com.example.guardianangel;

import java.io.File;
import android.Manifest;
import android.app.Activity;
import android.app.PendingIntent;
import android.content.Context;
import android.content.IntentFilter;
import android.content.pm.PackageManager;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Environment;
import android.provider.MediaStore;
import android.app.SearchManager;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.SupportMapFragment;


public class Locationinfo extends AppCompatActivity {

    LocationManager locManager;
    LocationListener locationListener;
    LocationReceiver receiver;
    @Override
    //////////////////////////////////
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setTitle("Guardian Angel");
        Button btnDial = (Button) findViewById(R.id.btnDial);
        Button btnWeb = (Button) findViewById(R.id.btnWeb);
        Button btnGoogle = (Button) findViewById(R.id.btnGoogle);
        Button btnSms = (Button) findViewById(R.id.btnSms);
        /////////////버튼////////////////
        btnDial.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Uri uri = Uri.parse("tel:112");
                Intent intent = new Intent(Intent.ACTION_DIAL, uri);
                startActivity(intent);
            }
        });
        btnSms.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Intent intent = new Intent(Intent.ACTION_SENDTO);
                intent.putExtra("sms_body", "살려주세요");
                intent.setData(Uri.parse("smsto:" + Uri.encode("112")));
                startActivity(intent);
            }
        });
        btnWeb.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Uri uri = Uri.parse("https://www.police.go.kr/index.do");
                Intent intent = new Intent(Intent.ACTION_VIEW, uri);
                startActivity(intent);
            }
        });
        btnGoogle.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Uri uri = Uri.parse("http://maps.google.com/maps?q="
                        + 37.554264 + "," + 126.913598);
                Intent intent = new Intent(Intent.ACTION_VIEW, uri);
                startActivity(intent);
            }
        });
        ///////////////////////////////////////
        ///////////구글맵//////////////////////

        /////////////경도위도///////////////////

        locManager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
        Button getLocation = (Button) findViewById(R.id.getLocation);
        final TextView locationText = (TextView) findViewById(R.id.location);

        locationListener = new LocationListener() {

            @Override
            public void onLocationChanged(Location location) {
                locationText.setText(
                        "\n" +
                                "당신의 위치는\n" +
                                "위도 : " + location.getLatitude() + "\n" +
                                "경도 : " + location.getLongitude());
            }

            @Override
            public void onProviderDisabled(String provider) {
                // TODO Auto-generated method stub
            }

            @Override
            public void onProviderEnabled(String provider) {
                // TODO Auto-generated method stub
            }

            @Override
            public void onStatusChanged(String provider, int status, Bundle extras) {
                // TODO Auto-generated method stub
            }
        };

        getLocation.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (checkSelfPermission(Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && checkSelfPermission(Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
                    return;
                }
                locManager.requestLocationUpdates(LocationManager.GPS_PROVIDER, 3000, 0, locationListener);
            }
        });

        // 리시버가 받을 수 있도록 설정
        // 액션이 com.androidhuman.exmple.Location인 브로드캐스트 메시지를 받도록 설정
        receiver = new LocationReceiver();
        IntentFilter filter = new IntentFilter("com.androidhuman.example.Location");
        registerReceiver(receiver, filter);

        // ProximityAlert 등록
        Intent intent = new Intent("com.androidhuman.example.Location");
        PendingIntent proximityIntent = PendingIntent.getBroadcast(this, 0, intent, 0);
        // 전과자 거주지
        locManager.addProximityAlert(36.852431, 127.150109, 2f, -1, proximityIntent);
    }
}

