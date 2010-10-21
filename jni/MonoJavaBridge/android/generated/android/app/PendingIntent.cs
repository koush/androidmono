namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PendingIntent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PendingIntent()
		{
			InitJNI();
		}
		internal PendingIntent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CanceledException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CanceledException()
			{
				InitJNI();
			}
			protected CanceledException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _CanceledException2005;
			public CanceledException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException2005);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _CanceledException2006;
			public CanceledException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException2006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _CanceledException2007;
			public CanceledException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException2007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.CanceledException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$CanceledException"));
				global::android.app.PendingIntent.CanceledException._CanceledException2005 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "()V");
				global::android.app.PendingIntent.CanceledException._CanceledException2006 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::android.app.PendingIntent.CanceledException._CanceledException2007 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.PendingIntent.OnFinished_))]
		public interface OnFinished  : global::MonoJavaBridge.IJavaObject 
		{
			void onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.PendingIntent.OnFinished))]
		public sealed partial class OnFinished_ : java.lang.Object, OnFinished
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnFinished_()
			{
				InitJNI();
			}
			internal OnFinished_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onSendFinished2008;
			 void android.app.PendingIntent.OnFinished.onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent.OnFinished_._onSendFinished2008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.OnFinished_.staticClass, global::android.app.PendingIntent.OnFinished_._onSendFinished2008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.OnFinished_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$OnFinished"));
				global::android.app.PendingIntent.OnFinished_._onSendFinished2008 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.OnFinished_.staticClass, "onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals2009;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.PendingIntent._equals2009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._equals2009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2010;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._toString2010)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._toString2010)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2011;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.PendingIntent._hashCode2011);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._hashCode2011);
		}
		internal static global::MonoJavaBridge.MethodId _send2012;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send2013;
		public void send() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2013);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2013);
		}
		internal static global::MonoJavaBridge.MethodId _send2014;
		public void send(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _send2015;
		public void send(int arg0, android.app.PendingIntent.OnFinished arg1, android.os.Handler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send2016;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, android.app.PendingIntent.OnFinished arg3, android.os.Handler arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getService2017;
		public static global::android.app.PendingIntent getService(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getService2017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _cancel2018;
		public void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._cancel2018);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._cancel2018);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2019;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._writeToParcel2019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writeToParcel2019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2020;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.PendingIntent._describeContents2020);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._describeContents2020);
		}
		internal static global::MonoJavaBridge.MethodId _getActivity2021;
		public static global::android.app.PendingIntent getActivity(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getActivity2021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcast2022;
		public static global::android.app.PendingIntent getBroadcast(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getBroadcast2022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		public new global::android.content.IntentSender IntentSender
		{
			get
			{
				return getIntentSender();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntentSender2023;
		public global::android.content.IntentSender getIntentSender() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._getIntentSender2023)) as android.content.IntentSender;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getIntentSender2023)) as android.content.IntentSender;
		}
		public new global::java.lang.String TargetPackage
		{
			get
			{
				return getTargetPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetPackage2024;
		public global::java.lang.String getTargetPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._getTargetPackage2024)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getTargetPackage2024)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writePendingIntentOrNullToParcel2025;
		public static void writePendingIntentOrNullToParcel(android.app.PendingIntent arg0, android.os.Parcel arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writePendingIntentOrNullToParcel2025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readPendingIntentOrNullFromParcel2026;
		public static global::android.app.PendingIntent readPendingIntentOrNullFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._readPendingIntentOrNullFromParcel2026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
		}
		public static int FLAG_ONE_SHOT
		{
			get
			{
				return 1073741824;
			}
		}
		public static int FLAG_NO_CREATE
		{
			get
			{
				return 536870912;
			}
		}
		public static int FLAG_CANCEL_CURRENT
		{
			get
			{
				return 268435456;
			}
		}
		public static int FLAG_UPDATE_CURRENT
		{
			get
			{
				return 134217728;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2031;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.PendingIntent.staticClass, _CREATOR2031)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.PendingIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent"));
			global::android.app.PendingIntent._equals2009 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.app.PendingIntent._toString2010 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.PendingIntent._hashCode2011 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "hashCode", "()I");
			global::android.app.PendingIntent._send2012 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;)V");
			global::android.app.PendingIntent._send2013 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "()V");
			global::android.app.PendingIntent._send2014 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(I)V");
			global::android.app.PendingIntent._send2015 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._send2016 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._getService2017 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._cancel2018 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "cancel", "()V");
			global::android.app.PendingIntent._writeToParcel2019 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.PendingIntent._describeContents2020 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "describeContents", "()I");
			global::android.app.PendingIntent._getActivity2021 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getBroadcast2022 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getIntentSender2023 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getIntentSender", "()Landroid/content/IntentSender;");
			global::android.app.PendingIntent._getTargetPackage2024 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getTargetPackage", "()Ljava/lang/String;");
			global::android.app.PendingIntent._writePendingIntentOrNullToParcel2025 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V");
			global::android.app.PendingIntent._readPendingIntentOrNullFromParcel2026 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._CREATOR2031 = @__env.GetStaticFieldIDNoThrow(global::android.app.PendingIntent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
