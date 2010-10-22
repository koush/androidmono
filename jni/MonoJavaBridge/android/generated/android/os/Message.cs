namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Message : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Message()
		{
			InitJNI();
		}
		internal Message(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString9889;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._toString9889)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._toString9889)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getData9890;
		public global::android.os.Bundle getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._getData9890)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getData9890)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9891;
		public static global::android.os.Message obtain(android.os.Handler arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9892;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9893;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9894;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9895;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3, java.lang.Object arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9896;
		public static global::android.os.Message obtain(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9897;
		public static global::android.os.Message obtain(android.os.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9898;
		public static global::android.os.Message obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain9898)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9899;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._recycle9899);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._recycle9899);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9900;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._writeToParcel9900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._writeToParcel9900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9901;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Message._describeContents9901);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._describeContents9901);
		}
		internal static global::MonoJavaBridge.MethodId _setData9902;
		public void setData(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._setData9902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._setData9902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Runnable Callback
		{
			get
			{
				return getCallback();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallback9903;
		public global::java.lang.Runnable getCallback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._getCallback9903)) as java.lang.Runnable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getCallback9903)) as java.lang.Runnable;
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom9904;
		public void copyFrom(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._copyFrom9904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._copyFrom9904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long When
		{
			get
			{
				return getWhen();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWhen9905;
		public long getWhen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Message._getWhen9905);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getWhen9905);
		}
		internal static global::MonoJavaBridge.MethodId _setTarget9906;
		public void setTarget(android.os.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._setTarget9906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._setTarget9906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTarget9907;
		public global::android.os.Handler getTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._getTarget9907)) as android.os.Handler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getTarget9907)) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _peekData9908;
		public global::android.os.Bundle peekData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._peekData9908)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._peekData9908)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _sendToTarget9909;
		public void sendToTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._sendToTarget9909);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._sendToTarget9909);
		}
		internal static global::MonoJavaBridge.MethodId _Message9910;
		public Message()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Message.staticClass, global::android.os.Message._Message9910);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _what9911;
		public int what
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _what9911);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg19912;
		public int arg1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _arg19912);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg29913;
		public int arg2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _arg29913);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _obj9914;
		public global::java.lang.Object obj
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _obj9914)) as java.lang.Object;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _replyTo9915;
		public global::android.os.Messenger replyTo
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Messenger>(@__env.GetObjectField(this.JvmHandle, _replyTo9915)) as android.os.Messenger;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR9916;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Message.staticClass, _CREATOR9916)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Message.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Message"));
			global::android.os.Message._toString9889 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Message._getData9890 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getData", "()Landroid/os/Bundle;");
			global::android.os.Message._obtain9891 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;");
			global::android.os.Message._obtain9892 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;I)Landroid/os/Message;");
			global::android.os.Message._obtain9893 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain9894 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;III)Landroid/os/Message;");
			global::android.os.Message._obtain9895 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain9896 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Message;)Landroid/os/Message;");
			global::android.os.Message._obtain9897 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;)Landroid/os/Message;");
			global::android.os.Message._obtain9898 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "()Landroid/os/Message;");
			global::android.os.Message._recycle9899 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "recycle", "()V");
			global::android.os.Message._writeToParcel9900 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Message._describeContents9901 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "describeContents", "()I");
			global::android.os.Message._setData9902 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "setData", "(Landroid/os/Bundle;)V");
			global::android.os.Message._getCallback9903 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getCallback", "()Ljava/lang/Runnable;");
			global::android.os.Message._copyFrom9904 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "copyFrom", "(Landroid/os/Message;)V");
			global::android.os.Message._getWhen9905 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getWhen", "()J");
			global::android.os.Message._setTarget9906 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "setTarget", "(Landroid/os/Handler;)V");
			global::android.os.Message._getTarget9907 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getTarget", "()Landroid/os/Handler;");
			global::android.os.Message._peekData9908 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "peekData", "()Landroid/os/Bundle;");
			global::android.os.Message._sendToTarget9909 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "sendToTarget", "()V");
			global::android.os.Message._Message9910 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "<init>", "()V");
			global::android.os.Message._what9911 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "what", "I");
			global::android.os.Message._arg19912 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "arg1", "I");
			global::android.os.Message._arg29913 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "arg2", "I");
			global::android.os.Message._obj9914 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "obj", "Ljava/lang/Object;");
			global::android.os.Message._replyTo9915 = @__env.GetFieldIDNoThrow(global::android.os.Message.staticClass, "replyTo", "Landroid/os/Messenger;");
			global::android.os.Message._CREATOR9916 = @__env.GetStaticFieldIDNoThrow(global::android.os.Message.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
