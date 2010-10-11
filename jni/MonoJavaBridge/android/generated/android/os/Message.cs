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
		internal static global::MonoJavaBridge.MethodId _toString6492;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._toString6492)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._toString6492)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getData6493;
		public global::android.os.Bundle getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._getData6493)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getData6493)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6494;
		public static global::android.os.Message obtain(android.os.Handler arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6495;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6496;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6497;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6498;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3, java.lang.Object arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6499;
		public static global::android.os.Message obtain(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6500;
		public static global::android.os.Message obtain(android.os.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtain6501;
		public static global::android.os.Message obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Message.staticClass, global::android.os.Message._obtain6501)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _recycle6502;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._recycle6502);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._recycle6502);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6503;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._writeToParcel6503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._writeToParcel6503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6504;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Message._describeContents6504);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._describeContents6504);
		}
		internal static global::MonoJavaBridge.MethodId _setData6505;
		public void setData(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._setData6505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._setData6505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCallback6506;
		public global::java.lang.Runnable getCallback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._getCallback6506)) as java.lang.Runnable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getCallback6506)) as java.lang.Runnable;
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom6507;
		public void copyFrom(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._copyFrom6507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._copyFrom6507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWhen6508;
		public long getWhen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Message._getWhen6508);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getWhen6508);
		}
		internal static global::MonoJavaBridge.MethodId _setTarget6509;
		public void setTarget(android.os.Handler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._setTarget6509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._setTarget6509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTarget6510;
		public global::android.os.Handler getTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._getTarget6510)) as android.os.Handler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._getTarget6510)) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _peekData6511;
		public global::android.os.Bundle peekData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Message._peekData6511)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._peekData6511)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _sendToTarget6512;
		public void sendToTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Message._sendToTarget6512);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Message.staticClass, global::android.os.Message._sendToTarget6512);
		}
		internal static global::MonoJavaBridge.MethodId _Message6513;
		public Message()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Message.staticClass, global::android.os.Message._Message6513);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _what6514;
		public int what
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg16515;
		public int arg1
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _arg26516;
		public int arg2
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _obj6517;
		public global::java.lang.Object obj
		{
			get
			{
				return default(global::java.lang.Object);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _replyTo6518;
		public global::android.os.Messenger replyTo
		{
			get
			{
				return default(global::android.os.Messenger);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6519;
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
			global::android.os.Message.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Message"));
			global::android.os.Message._toString6492 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Message._getData6493 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getData", "()Landroid/os/Bundle;");
			global::android.os.Message._obtain6494 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;");
			global::android.os.Message._obtain6495 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;I)Landroid/os/Message;");
			global::android.os.Message._obtain6496 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain6497 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;III)Landroid/os/Message;");
			global::android.os.Message._obtain6498 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain6499 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Message;)Landroid/os/Message;");
			global::android.os.Message._obtain6500 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;)Landroid/os/Message;");
			global::android.os.Message._obtain6501 = @__env.GetStaticMethodIDNoThrow(global::android.os.Message.staticClass, "obtain", "()Landroid/os/Message;");
			global::android.os.Message._recycle6502 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "recycle", "()V");
			global::android.os.Message._writeToParcel6503 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Message._describeContents6504 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "describeContents", "()I");
			global::android.os.Message._setData6505 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "setData", "(Landroid/os/Bundle;)V");
			global::android.os.Message._getCallback6506 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getCallback", "()Ljava/lang/Runnable;");
			global::android.os.Message._copyFrom6507 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "copyFrom", "(Landroid/os/Message;)V");
			global::android.os.Message._getWhen6508 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getWhen", "()J");
			global::android.os.Message._setTarget6509 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "setTarget", "(Landroid/os/Handler;)V");
			global::android.os.Message._getTarget6510 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "getTarget", "()Landroid/os/Handler;");
			global::android.os.Message._peekData6511 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "peekData", "()Landroid/os/Bundle;");
			global::android.os.Message._sendToTarget6512 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "sendToTarget", "()V");
			global::android.os.Message._Message6513 = @__env.GetMethodIDNoThrow(global::android.os.Message.staticClass, "<init>", "()V");
		}
	}
}
