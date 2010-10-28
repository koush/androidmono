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
			internal static global::MonoJavaBridge.MethodId _CanceledException2009;
			public CanceledException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException2009);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _CanceledException2010;
			public CanceledException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException2010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _CanceledException2011;
			public CanceledException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException2011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static CanceledException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.CanceledException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$CanceledException"));
				global::android.app.PendingIntent.CanceledException._CanceledException2009 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "()V");
				global::android.app.PendingIntent.CanceledException._CanceledException2010 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::android.app.PendingIntent.CanceledException._CanceledException2011 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onSendFinished2012;
			void android.app.PendingIntent.OnFinished.onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent.OnFinished_._onSendFinished2012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.OnFinished_.staticClass, global::android.app.PendingIntent.OnFinished_._onSendFinished2012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			static OnFinished_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.OnFinished_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$OnFinished"));
				global::android.app.PendingIntent.OnFinished_._onSendFinished2012 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.OnFinished_.staticClass, "onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnFinishedDelegate(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);

		internal partial class OnFinishedDelegateWrapper : java.lang.Object, OnFinished
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnFinishedDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnFinishedDelegateWrapper2013;
			public OnFinishedDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.OnFinishedDelegateWrapper.staticClass, global::android.app.PendingIntent.OnFinishedDelegateWrapper._OnFinishedDelegateWrapper2013);
				Init(@__env, handle);
			}
			static OnFinishedDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.OnFinishedDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent_OnFinishedDelegateWrapper"));
				global::android.app.PendingIntent.OnFinishedDelegateWrapper._OnFinishedDelegateWrapper2013 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.OnFinishedDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _equals2014;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.PendingIntent._equals2014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._equals2014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2015;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._toString2015)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._toString2015)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2016;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.PendingIntent._hashCode2016);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._hashCode2016);
		}
		internal static global::MonoJavaBridge.MethodId _send2017;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send2018;
		public void send()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2018);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2018);
		}
		internal static global::MonoJavaBridge.MethodId _send2019;
		public void send(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _send2020;
		public void send(int arg0, android.app.PendingIntent.OnFinished arg1, android.os.Handler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void send(int arg0, global::android.app.PendingIntent.OnFinishedDelegate arg1, android.os.Handler arg2)
		{
			send(arg0, (global::android.app.PendingIntent.OnFinishedDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _send2021;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, android.app.PendingIntent.OnFinished arg3, android.os.Handler arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send2021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send2021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, global::android.app.PendingIntent.OnFinishedDelegate arg3, android.os.Handler arg4)
		{
			send(arg0, arg1, arg2, (global::android.app.PendingIntent.OnFinishedDelegateWrapper)arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _getService2022;
		public static global::android.app.PendingIntent getService(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getService2022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _cancel2023;
		public void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._cancel2023);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._cancel2023);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2024;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._writeToParcel2024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writeToParcel2024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2025;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.PendingIntent._describeContents2025);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._describeContents2025);
		}
		internal static global::MonoJavaBridge.MethodId _getActivity2026;
		public static global::android.app.PendingIntent getActivity(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getActivity2026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcast2027;
		public static global::android.app.PendingIntent getBroadcast(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getBroadcast2027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		public new global::android.content.IntentSender IntentSender
		{
			get
			{
				return getIntentSender();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntentSender2028;
		public global::android.content.IntentSender getIntentSender()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._getIntentSender2028)) as android.content.IntentSender;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getIntentSender2028)) as android.content.IntentSender;
		}
		public new global::java.lang.String TargetPackage
		{
			get
			{
				return getTargetPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetPackage2029;
		public global::java.lang.String getTargetPackage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._getTargetPackage2029)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getTargetPackage2029)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writePendingIntentOrNullToParcel2030;
		public static void writePendingIntentOrNullToParcel(android.app.PendingIntent arg0, android.os.Parcel arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writePendingIntentOrNullToParcel2030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readPendingIntentOrNullFromParcel2031;
		public static global::android.app.PendingIntent readPendingIntentOrNullFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._readPendingIntentOrNullFromParcel2031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR2036;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.PendingIntent.staticClass, _CREATOR2036)) as android.os.Parcelable_Creator;
			}
		}
		static PendingIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.PendingIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent"));
			global::android.app.PendingIntent._equals2014 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.app.PendingIntent._toString2015 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.PendingIntent._hashCode2016 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "hashCode", "()I");
			global::android.app.PendingIntent._send2017 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;)V");
			global::android.app.PendingIntent._send2018 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "()V");
			global::android.app.PendingIntent._send2019 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(I)V");
			global::android.app.PendingIntent._send2020 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._send2021 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._getService2022 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._cancel2023 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "cancel", "()V");
			global::android.app.PendingIntent._writeToParcel2024 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.PendingIntent._describeContents2025 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "describeContents", "()I");
			global::android.app.PendingIntent._getActivity2026 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getBroadcast2027 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getIntentSender2028 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getIntentSender", "()Landroid/content/IntentSender;");
			global::android.app.PendingIntent._getTargetPackage2029 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getTargetPackage", "()Ljava/lang/String;");
			global::android.app.PendingIntent._writePendingIntentOrNullToParcel2030 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V");
			global::android.app.PendingIntent._readPendingIntentOrNullFromParcel2031 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._CREATOR2036 = @__env.GetStaticFieldIDNoThrow(global::android.app.PendingIntent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
