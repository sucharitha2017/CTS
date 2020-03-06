package com.reddy98.vishnuvardhan.progressbar;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ProgressBar;

public class MainActivity extends AppCompatActivity {

    ProgressBar prg;
    Button bt50,bt25,bt15,bt10;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        prg=findViewById(R.id.progress);
        bt50=findViewById(R.id.button);
        bt25=findViewById(R.id.button2);
        bt10=findViewById(R.id.button3);
        bt15=findViewById(R.id.button6);

        bt50.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                prg.setProgress(50);
            }
        });
        bt25.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                prg.setProgress(75);
            }
        });
        bt10.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                prg.setProgress(85);
            }
        });
        bt15.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                prg.setProgress(100);
            }
        });
    }
}
