namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Message : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Message(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Message.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.Message._m0) as java.lang.String;
		}
		public new global::android.os.Bundle Data
		{
			get
			{
				return getData();
			}
			set
			{
				setData(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::android.os.Bundle getData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.os.Message.staticClass, "getData", "()Landroid/os/Bundle;", ref global::android.os.Message._m1) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.os.Message obtain(android.os.Handler arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m2.native == global::System.IntPtr.Zero)
				global::android.os.Message._m2 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		public static android.os.Message obtain(android.os.Handler arg0, global::java.lang.RunnableDelegate arg1)
		{
			return obtain(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m3.native == global::System.IntPtr.Zero)
				global::android.os.Message._m3 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;I)Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m4.native == global::System.IntPtr.Zero)
				global::android.os.Message._m4 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m5.native == global::System.IntPtr.Zero)
				global::android.os.Message._m5 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;III)Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3, java.lang.Object arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m6.native == global::System.IntPtr.Zero)
				global::android.os.Message._m6 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.os.Message obtain(android.os.Message arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m7.native == global::System.IntPtr.Zero)
				global::android.os.Message._m7 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Message;)Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.os.Message obtain(android.os.Handler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m8.native == global::System.IntPtr.Zero)
				global::android.os.Message._m8 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;)Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::android.os.Message obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m9.native == global::System.IntPtr.Zero)
				global::android.os.Message._m9 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "()Landroid/os/Message;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._m9)) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Message.staticClass, "recycle", "()V", ref global::android.os.Message._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Message.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.Message._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Message.staticClass, "describeContents", "()I", ref global::android.os.Message._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public void setData(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Message.staticClass, "setData", "(Landroid/os/Bundle;)V", ref global::android.os.Message._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.RunnableDelegate Callback
		{
			get
			{
				return new global::java.lang.RunnableDelegate(getCallback().run);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.Runnable getCallback()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Runnable>(this, global::android.os.Message.staticClass, "getCallback", "()Ljava/lang/Runnable;", ref global::android.os.Message._m14) as java.lang.Runnable;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public void copyFrom(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Message.staticClass, "copyFrom", "(Landroid/os/Message;)V", ref global::android.os.Message._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long When
		{
			get
			{
				return getWhen();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public long getWhen()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.Message.staticClass, "getWhen", "()J", ref global::android.os.Message._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public void setTarget(android.os.Handler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Message.staticClass, "setTarget", "(Landroid/os/Handler;)V", ref global::android.os.Message._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Handler Target
		{
			get
			{
				return getTarget();
			}
			set
			{
				setTarget(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public global::android.os.Handler getTarget()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Message.staticClass, "getTarget", "()Landroid/os/Handler;", ref global::android.os.Message._m18) as android.os.Handler;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public global::android.os.Bundle peekData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.os.Message.staticClass, "peekData", "()Landroid/os/Bundle;", ref global::android.os.Message._m19) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public void sendToTarget()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Message.staticClass, "sendToTarget", "()V", ref global::android.os.Message._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public Message() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Message._m21.native == global::System.IntPtr.Zero)
				global::android.os.Message._m21 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Message.staticClass, global::android.os.Message._m21);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _what4003;
		public int what
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _what4003);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg14004;
		public int arg1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _arg14004);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg24005;
		public int arg2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _arg24005);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _obj4006;
		public global::java.lang.Object obj
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _obj4006)) as java.lang.Object;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _replyTo4007;
		public global::android.os.Messenger replyTo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Messenger>(@__env.GetObjectField(this.JvmHandle, _replyTo4007)) as android.os.Messenger;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4008;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Message.staticClass, _CREATOR4008)) as android.os.Parcelable_Creator;
			}
		}
		static Message()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Message.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Message"));
			global::android.os.Message._what4003 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "what", "I");
			global::android.os.Message._arg14004 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "arg1", "I");
			global::android.os.Message._arg24005 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "arg2", "I");
			global::android.os.Message._obj4006 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "obj", "Ljava/lang/Object;");
			global::android.os.Message._replyTo4007 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "replyTo", "Landroid/os/Messenger;");
			global::android.os.Message._CREATOR4008 = @__env.GetStaticFieldIDNoThrow(global::android.os.Message.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
