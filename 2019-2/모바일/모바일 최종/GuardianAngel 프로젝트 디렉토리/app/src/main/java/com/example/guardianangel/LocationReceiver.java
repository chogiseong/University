package com.example.guardianangel;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.location.LocationManager;
import android.os.Vibrator;
import android.widget.Toast;

public class LocationReceiver extends BroadcastReceiver {

    public Vibrator vibrator;

    @Override
    public void onReceive(Context context, Intent intent) {
        boolean isEntering = intent.getBooleanExtra(LocationManager.KEY_PROXIMITY_ENTERING, false);

        vibrator = (Vibrator) context.getSystemService(Context.VIBRATOR_SERVICE);

        if(isEntering)
            Toast.makeText(context, "위험한 길입니다.", Toast.LENGTH_LONG).show();
        else
            Toast.makeText(context, "안전한 길입니다.", Toast.LENGTH_LONG).show();
        vibrator.vibrate(1000);

    }


}