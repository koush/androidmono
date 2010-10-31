namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PendingIntent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PendingIntent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class CanceledException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CanceledException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public CanceledException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.PendingIntent.CanceledException._m0.native == global::System.IntPtr.Zero)
					global::android.app.PendingIntent.CanceledException._m0 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._m0);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public CanceledException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.PendingIntent.CanceledException._m1.native == global::System.IntPtr.Zero)
					global::android.app.PendingIntent.CanceledException._m1 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public CanceledException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.PendingIntent.CanceledException._m2.native == global::System.IntPtr.Zero)
					global::android.app.PendingIntent.CanceledException._m2 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static CanceledException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.CanceledException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$CanceledException"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.PendingIntent.OnFinished_))]
		public partial interface OnFinished  : global::MonoJavaBridge.IJavaObject 
		{
			void onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.PendingIntent.OnFinished))]
		internal sealed partial class OnFinished_ : java.lang.Object, OnFinished
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnFinished_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.app.PendingIntent.OnFinished.onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.OnFinished_.staticClass, "onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.app.PendingIntent.OnFinished_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			static OnFinished_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.OnFinished_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$OnFinished"));
			}
		}

		public delegate void OnFinishedDelegate(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);

		internal partial class OnFinishedDelegateWrapper : java.lang.Object, OnFinished
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnFinishedDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnFinishedDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.PendingIntent.OnFinishedDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.app.PendingIntent.OnFinishedDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.OnFinishedDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.OnFinishedDelegateWrapper.staticClass, global::android.app.PendingIntent.OnFinishedDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnFinishedDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.OnFinishedDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent_OnFinishedDelegateWrapper"));
			}
		}
		internal partial class OnFinishedDelegateWrapper
		{
			private OnFinishedDelegate myDelegate;
			public void onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4)
			{
				myDelegate(arg0, arg1, arg2, arg3, arg4);
			}
			public static implicit operator OnFinishedDelegateWrapper(OnFinishedDelegate d)
			{
				global::android.app.PendingIntent.OnFinishedDelegateWrapper ret = new global::android.app.PendingIntent.OnFinishedDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.PendingIntent.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.app.PendingIntent._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.PendingIntent.staticClass, "toString", "()Ljava/lang/String;", ref global::android.app.PendingIntent._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.PendingIntent.staticClass, "hashCode", "()I", ref global::android.app.PendingIntent._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;)V", ref global::android.app.PendingIntent._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void send()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.staticClass, "send", "()V", ref global::android.app.PendingIntent._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void send(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.staticClass, "send", "(I)V", ref global::android.app.PendingIntent._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void send(int arg0, android.app.PendingIntent.OnFinished arg1, android.os.Handler arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.staticClass, "send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V", ref global::android.app.PendingIntent._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void send(int arg0, global::android.app.PendingIntent.OnFinishedDelegate arg1, android.os.Handler arg2)
		{
			send(arg0, (global::android.app.PendingIntent.OnFinishedDelegateWrapper)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, android.app.PendingIntent.OnFinished arg3, android.os.Handler arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V", ref global::android.app.PendingIntent._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, global::android.app.PendingIntent.OnFinishedDelegate arg3, android.os.Handler arg4)
		{
			send(arg0, arg1, arg2, (global::android.app.PendingIntent.OnFinishedDelegateWrapper)arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.app.PendingIntent getService(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.PendingIntent._m8.native == global::System.IntPtr.Zero)
				global::android.app.PendingIntent._m8 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.staticClass, "cancel", "()V", ref global::android.app.PendingIntent._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.PendingIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.PendingIntent._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.PendingIntent.staticClass, "describeContents", "()I", ref global::android.app.PendingIntent._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::android.app.PendingIntent getActivity(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.PendingIntent._m12.native == global::System.IntPtr.Zero)
				global::android.app.PendingIntent._m12 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::android.app.PendingIntent getBroadcast(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.PendingIntent._m13.native == global::System.IntPtr.Zero)
				global::android.app.PendingIntent._m13 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		public new global::android.content.IntentSender IntentSender
		{
			get
			{
				return getIntentSender();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::android.content.IntentSender getIntentSender()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.PendingIntent.staticClass, "getIntentSender", "()Landroid/content/IntentSender;", ref global::android.app.PendingIntent._m14) as android.content.IntentSender;
		}
		public new global::java.lang.String TargetPackage
		{
			get
			{
				return getTargetPackage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.String getTargetPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.PendingIntent.staticClass, "getTargetPackage", "()Ljava/lang/String;", ref global::android.app.PendingIntent._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void writePendingIntentOrNullToParcel(android.app.PendingIntent arg0, android.os.Parcel arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.PendingIntent._m16.native == global::System.IntPtr.Zero)
				global::android.app.PendingIntent._m16 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::android.app.PendingIntent readPendingIntentOrNullFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.PendingIntent._m17.native == global::System.IntPtr.Zero)
				global::android.app.PendingIntent._m17 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR1393;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.PendingIntent.staticClass, _CREATOR1393)) as android.os.Parcelable_Creator;
			}
		}
		static PendingIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.PendingIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent"));
			global::android.app.PendingIntent._CREATOR1393 = @__env.GetStaticFieldIDNoThrow(global::android.app.PendingIntent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
