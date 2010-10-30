namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IntentSender : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IntentSender(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.IntentSender.OnFinished_))]
		public partial interface OnFinished  : global::MonoJavaBridge.IJavaObject 
		{
			void onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.IntentSender.OnFinished))]
		internal sealed partial class OnFinished_ : java.lang.Object, OnFinished
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnFinished_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.content.IntentSender.OnFinished.onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentSender.OnFinished_.staticClass, "onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.IntentSender.OnFinished_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			static OnFinished_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.OnFinished_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender$OnFinished"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnFinishedDelegate(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);

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
				if (global::android.content.IntentSender.OnFinishedDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.content.IntentSender.OnFinishedDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.OnFinishedDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.OnFinishedDelegateWrapper.staticClass, global::android.content.IntentSender.OnFinishedDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnFinishedDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.OnFinishedDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender_OnFinishedDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnFinishedDelegateWrapper
		{
			private OnFinishedDelegate myDelegate;
			public void onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4)
			{
				myDelegate(arg0, arg1, arg2, arg3, arg4);
			}
			public static implicit operator OnFinishedDelegateWrapper(OnFinishedDelegate d)
			{
				global::android.content.IntentSender.OnFinishedDelegateWrapper ret = new global::android.content.IntentSender.OnFinishedDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SendIntentException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SendIntentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public SendIntentException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentSender.SendIntentException._m0.native == global::System.IntPtr.Zero)
					global::android.content.IntentSender.SendIntentException._m0 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._m0);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public SendIntentException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentSender.SendIntentException._m1.native == global::System.IntPtr.Zero)
					global::android.content.IntentSender.SendIntentException._m1 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public SendIntentException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.IntentSender.SendIntentException._m2.native == global::System.IntPtr.Zero)
					global::android.content.IntentSender.SendIntentException._m2 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SendIntentException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.SendIntentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender$SendIntentException"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.IntentSender.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.IntentSender._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.IntentSender.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.IntentSender._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentSender.staticClass, "hashCode", "()I", ref global::android.content.IntentSender._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentSender.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.IntentSender._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.IntentSender.staticClass, "describeContents", "()I", ref global::android.content.IntentSender._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void sendIntent(android.content.Context arg0, int arg1, android.content.Intent arg2, android.content.IntentSender.OnFinished arg3, android.os.Handler arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.IntentSender.staticClass, "sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$OnFinished;Landroid/os/Handler;)V", ref global::android.content.IntentSender._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void sendIntent(android.content.Context arg0, int arg1, android.content.Intent arg2, global::android.content.IntentSender.OnFinishedDelegate arg3, android.os.Handler arg4)
		{
			sendIntent(arg0, arg1, arg2, (global::android.content.IntentSender.OnFinishedDelegateWrapper)arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void writeIntentSenderOrNullToParcel(android.content.IntentSender arg0, android.os.Parcel arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentSender._m6.native == global::System.IntPtr.Zero)
				global::android.content.IntentSender._m6 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentSender.staticClass, "writeIntentSenderOrNullToParcel", "(Landroid/content/IntentSender;Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.content.IntentSender.staticClass, global::android.content.IntentSender._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.content.IntentSender readIntentSenderOrNullFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.IntentSender._m7.native == global::System.IntPtr.Zero)
				global::android.content.IntentSender._m7 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentSender.staticClass, "readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.IntentSender.staticClass, global::android.content.IntentSender._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.IntentSender;
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1870;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.IntentSender.staticClass, _CREATOR1870)) as android.os.Parcelable_Creator;
			}
		}
		static IntentSender()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.IntentSender.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender"));
			global::android.content.IntentSender._CREATOR1870 = @__env.GetStaticFieldIDNoThrow(global::android.content.IntentSender.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
