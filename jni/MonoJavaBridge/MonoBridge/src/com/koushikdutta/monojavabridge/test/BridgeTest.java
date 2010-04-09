package com.koushikdutta.monojavabridge.test;

import com.koushikdutta.monojavabridge.MonoBridge;


public class BridgeTest extends Test {
	
	static 
	{
		MonoBridge.prelink(BridgeTest.class);
	}
	public native void foo();
	
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		BridgeTest test = new BridgeTest();
	}
}
