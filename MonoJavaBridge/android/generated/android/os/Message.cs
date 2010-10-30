namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Message : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Message(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString9934;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._toString9934)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getData9935;
		public global::android.os.Bundle getData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getData9935)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9936;
		public static global::android.os.Message obtain(android.os.Handler arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		public static android.os.Message obtain(android.os.Handler arg0, global::java.lang.RunnableDelegate arg1)
		{
			return obtain(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _obtain9937;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9938;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9939;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9940;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3, java.lang.Object arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9941;
		public static global::android.os.Message obtain(android.os.Message arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9942;
		public static global::android.os.Message obtain(android.os.Handler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9943;
		public static global::android.os.Message obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9943)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9944;
		public void recycle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._recycle9944);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9945;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._writeToParcel9945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9946;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._describeContents9946);
		}
		internal static global::MonoJavaBridge.MethodId _setData9947;
		public void setData(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._setData9947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.RunnableDelegate Callback
		{
			get
			{
				return new global::java.lang.RunnableDelegate(getCallback().run);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallback9948;
		public global::java.lang.Runnable getCallback()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getCallback9948)) as java.lang.Runnable;
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom9949;
		public void copyFrom(android.os.Message arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._copyFrom9949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long When
		{
			get
			{
				return getWhen();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWhen9950;
		public long getWhen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getWhen9950);
		}
		internal static global::MonoJavaBridge.MethodId _setTarget9951;
		public void setTarget(android.os.Handler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._setTarget9951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTarget9952;
		public global::android.os.Handler getTarget()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getTarget9952)) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _peekData9953;
		public global::android.os.Bundle peekData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._peekData9953)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _sendToTarget9954;
		public void sendToTarget()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._sendToTarget9954);
		}
		internal static global::MonoJavaBridge.MethodId _Message9955;
		public Message() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Message.staticClass, global::android.os.Message._Message9955);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _what9956;
		public int what
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _what9956);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg19957;
		public int arg1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _arg19957);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg29958;
		public int arg2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _arg29958);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _obj9959;
		public global::java.lang.Object obj
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _obj9959)) as java.lang.Object;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _replyTo9960;
		public global::android.os.Messenger replyTo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Messenger>(@__env.GetObjectField(this.JvmHandle, _replyTo9960)) as android.os.Messenger;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR9961;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Message.staticClass, _CREATOR9961)) as android.os.Parcelable_Creator;
			}
		}
		static Message()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Message.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Message"));
			global::android.os.Message._toString9934 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Message._getData9935 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getData", "()Landroid/os/Bundle;");
			global::android.os.Message._obtain9936 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;");
			global::android.os.Message._obtain9937 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;I)Landroid/os/Message;");
			global::android.os.Message._obtain9938 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain9939 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;III)Landroid/os/Message;");
			global::android.os.Message._obtain9940 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain9941 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Message;)Landroid/os/Message;");
			global::android.os.Message._obtain9942 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;)Landroid/os/Message;");
			global::android.os.Message._obtain9943 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "()Landroid/os/Message;");
			global::android.os.Message._recycle9944 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "recycle", "()V");
			global::android.os.Message._writeToParcel9945 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Message._describeContents9946 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "describeContents", "()I");
			global::android.os.Message._setData9947 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "setData", "(Landroid/os/Bundle;)V");
			global::android.os.Message._getCallback9948 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getCallback", "()Ljava/lang/Runnable;");
			global::android.os.Message._copyFrom9949 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "copyFrom", "(Landroid/os/Message;)V");
			global::android.os.Message._getWhen9950 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getWhen", "()J");
			global::android.os.Message._setTarget9951 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "setTarget", "(Landroid/os/Handler;)V");
			global::android.os.Message._getTarget9952 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getTarget", "()Landroid/os/Handler;");
			global::android.os.Message._peekData9953 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "peekData", "()Landroid/os/Bundle;");
			global::android.os.Message._sendToTarget9954 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "sendToTarget", "()V");
			global::android.os.Message._Message9955 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "<init>", "()V");
			global::android.os.Message._what9956 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "what", "I");
			global::android.os.Message._arg19957 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "arg1", "I");
			global::android.os.Message._arg29958 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "arg2", "I");
			global::android.os.Message._obj9959 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "obj", "Ljava/lang/Object;");
			global::android.os.Message._replyTo9960 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "replyTo", "Landroid/os/Messenger;");
			global::android.os.Message._CREATOR9961 = @__env.GetStaticFieldIDNoThrow(global::android.os.Message.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
