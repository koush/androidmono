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
			internal static global::MonoJavaBridge.MethodId _CanceledException707;
			public CanceledException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException707);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _CanceledException708;
			public CanceledException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _CanceledException709;
			public CanceledException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.CanceledException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$CanceledException"));
				global::android.app.PendingIntent.CanceledException._CanceledException707 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "()V");
				global::android.app.PendingIntent.CanceledException._CanceledException708 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::android.app.PendingIntent.CanceledException._CanceledException709 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
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
			internal static global::MonoJavaBridge.MethodId _onSendFinished710;
			 void android.app.PendingIntent.OnFinished.onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent.OnFinished_._onSendFinished710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.OnFinished_.staticClass, global::android.app.PendingIntent.OnFinished_._onSendFinished710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.PendingIntent.OnFinished_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent$OnFinished"));
				global::android.app.PendingIntent.OnFinished_._onSendFinished710 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.OnFinished_.staticClass, "onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals711;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.PendingIntent._equals711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._equals711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString712;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._toString712)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._toString712)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode713;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.PendingIntent._hashCode713);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._hashCode713);
		}
		internal static global::MonoJavaBridge.MethodId _send714;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send715;
		public void send() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send715);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send715);
		}
		internal static global::MonoJavaBridge.MethodId _send716;
		public void send(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _send717;
		public void send(int arg0, android.app.PendingIntent.OnFinished arg1, android.os.Handler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _send718;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, android.app.PendingIntent.OnFinished arg3, android.os.Handler arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._send718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getService719;
		public static global::android.app.PendingIntent getService(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getService719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _cancel720;
		public void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._cancel720);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._cancel720);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel721;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.PendingIntent._writeToParcel721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writeToParcel721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents722;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.PendingIntent._describeContents722);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._describeContents722);
		}
		internal static global::MonoJavaBridge.MethodId _getActivity723;
		public static global::android.app.PendingIntent getActivity(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getActivity723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcast724;
		public static global::android.app.PendingIntent getBroadcast(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getBroadcast724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.PendingIntent;
		}
		public new global::android.content.IntentSender IntentSender
		{
			get
			{
				return getIntentSender();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntentSender725;
		public global::android.content.IntentSender getIntentSender() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._getIntentSender725)) as android.content.IntentSender;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getIntentSender725)) as android.content.IntentSender;
		}
		public new global::java.lang.String TargetPackage
		{
			get
			{
				return getTargetPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetPackage726;
		public global::java.lang.String getTargetPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.PendingIntent._getTargetPackage726)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getTargetPackage726)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writePendingIntentOrNullToParcel727;
		public static void writePendingIntentOrNullToParcel(android.app.PendingIntent arg0, android.os.Parcel arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writePendingIntentOrNullToParcel727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readPendingIntentOrNullFromParcel728;
		public static global::android.app.PendingIntent readPendingIntentOrNullFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._readPendingIntentOrNullFromParcel728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.PendingIntent;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR729;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.PendingIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/PendingIntent"));
			global::android.app.PendingIntent._equals711 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.app.PendingIntent._toString712 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.PendingIntent._hashCode713 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "hashCode", "()I");
			global::android.app.PendingIntent._send714 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;)V");
			global::android.app.PendingIntent._send715 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "()V");
			global::android.app.PendingIntent._send716 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(I)V");
			global::android.app.PendingIntent._send717 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._send718 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._getService719 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._cancel720 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "cancel", "()V");
			global::android.app.PendingIntent._writeToParcel721 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.PendingIntent._describeContents722 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "describeContents", "()I");
			global::android.app.PendingIntent._getActivity723 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getBroadcast724 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getIntentSender725 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getIntentSender", "()Landroid/content/IntentSender;");
			global::android.app.PendingIntent._getTargetPackage726 = @__env.GetMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "getTargetPackage", "()Ljava/lang/String;");
			global::android.app.PendingIntent._writePendingIntentOrNullToParcel727 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V");
			global::android.app.PendingIntent._readPendingIntentOrNullFromParcel728 = @__env.GetStaticMethodIDNoThrow(global::android.app.PendingIntent.staticClass, "readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;");
		}
	}
}
