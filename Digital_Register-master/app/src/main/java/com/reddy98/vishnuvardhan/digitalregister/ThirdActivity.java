package com.reddy98.vishnuvardhan.digitalregister;

import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class ThirdActivity extends AppCompatActivity {

    Button NP;
    Button OOAD;
    Button ICG;
    Button MPI;
    Button CD;
    Button DIP;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_third);

        NP = findViewById(R.id.np);
        OOAD = findViewById(R.id.ooad);
        ICG = findViewById(R.id.icg);
        MPI = findViewById(R.id.mpi);
        CD = findViewById(R.id.cd);
        DIP = findViewById(R.id.dip);

        NP.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(ThirdActivity.this,FourthActivity.class);
                startActivity(intent);
            }
        });

        OOAD.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(ThirdActivity.this,FourthActivity.class);
                startActivity(intent);
            }
        });

        ICG.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(ThirdActivity.this,FourthActivity.class);
                startActivity(intent);
            }
        });

        MPI.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(ThirdActivity.this,FourthActivity.class);
                startActivity(intent);
            }
        });

        CD.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(ThirdActivity.this,FourthActivity.class);
                startActivity(intent);
            }
        });

        DIP.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(ThirdActivity.this,FourthActivity.class);
                startActivity(intent);
            }
        });
    }
}