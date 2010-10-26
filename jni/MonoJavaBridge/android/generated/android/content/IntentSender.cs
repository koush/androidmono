namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IntentSender : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntentSender()
		{
			InitJNI();
		}
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
			static OnFinished_()
			{
				InitJNI();
			}
			internal OnFinished_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onSendFinished3467;
			 void android.content.IntentSender.OnFinished.onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentSender.OnFinished_._onSendFinished3467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentSender.OnFinished_.staticClass, global::android.content.IntentSender.OnFinished_._onSendFinished3467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.OnFinished_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender$OnFinished"));
				global::android.content.IntentSender.OnFinished_._onSendFinished3467 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.OnFinished_.staticClass, "onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V");
			}
		}

		public delegate void OnFinishedDelegate(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);

		internal partial class OnFinishedDelegateWrapper : java.lang.Object, OnFinished
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnFinishedDelegateWrapper()
			{
				InitJNI();
			}
			protected OnFinishedDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnFinishedDelegateWrapper3468;
			public OnFinishedDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.OnFinishedDelegateWrapper.staticClass, global::android.content.IntentSender.OnFinishedDelegateWrapper._OnFinishedDelegateWrapper3468);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.OnFinishedDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender_OnFinishedDelegateWrapper"));
				global::android.content.IntentSender.OnFinishedDelegateWrapper._OnFinishedDelegateWrapper3468 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.OnFinishedDelegateWrapper.staticClass, "<init>", "()V");
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
			static SendIntentException()
			{
				InitJNI();
			}
			protected SendIntentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _SendIntentException3469;
			public SendIntentException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException3469);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _SendIntentException3470;
			public SendIntentException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException3470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _SendIntentException3471;
			public SendIntentException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException3471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.SendIntentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender$SendIntentException"));
				global::android.content.IntentSender.SendIntentException._SendIntentException3469 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "()V");
				global::android.content.IntentSender.SendIntentException._SendIntentException3470 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::android.content.IntentSender.SendIntentException._SendIntentException3471 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals3472;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentSender._equals3472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._equals3472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString3473;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentSender._toString3473)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._toString3473)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode3474;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentSender._hashCode3474);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._hashCode3474);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3475;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentSender._writeToParcel3475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._writeToParcel3475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3476;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentSender._describeContents3476);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._describeContents3476);
		}
		internal static global::MonoJavaBridge.MethodId _sendIntent3477;
		public virtual void sendIntent(android.content.Context arg0, int arg1, android.content.Intent arg2, android.content.IntentSender.OnFinished arg3, android.os.Handler arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentSender._sendIntent3477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._sendIntent3477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public void sendIntent(android.content.Context arg0, int arg1, android.content.Intent arg2, global::android.content.IntentSender.OnFinishedDelegate arg3, android.os.Handler arg4)
		{
			sendIntent(arg0, arg1, arg2, (global::android.content.IntentSender.OnFinishedDelegateWrapper)arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _writeIntentSenderOrNullToParcel3478;
		public static void writeIntentSenderOrNullToParcel(android.content.IntentSender arg0, android.os.Parcel arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.IntentSender.staticClass, global::android.content.IntentSender._writeIntentSenderOrNullToParcel3478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readIntentSenderOrNullFromParcel3479;
		public static global::android.content.IntentSender readIntentSenderOrNullFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.IntentSender.staticClass, global::android.content.IntentSender._readIntentSenderOrNullFromParcel3479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.IntentSender;
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3480;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.IntentSender.staticClass, _CREATOR3480)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.IntentSender.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender"));
			global::android.content.IntentSender._equals3472 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.IntentSender._toString3473 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.IntentSender._hashCode3474 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "hashCode", "()I");
			global::android.content.IntentSender._writeToParcel3475 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.IntentSender._describeContents3476 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "describeContents", "()I");
			global::android.content.IntentSender._sendIntent3477 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$OnFinished;Landroid/os/Handler;)V");
			global::android.content.IntentSender._writeIntentSenderOrNullToParcel3478 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentSender.staticClass, "writeIntentSenderOrNullToParcel", "(Landroid/content/IntentSender;Landroid/os/Parcel;)V");
			global::android.content.IntentSender._readIntentSenderOrNullFromParcel3479 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentSender.staticClass, "readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;");
			global::android.content.IntentSender._CREATOR3480 = @__env.GetStaticFieldIDNoThrow(global::android.content.IntentSender.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
