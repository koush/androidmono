namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Message : java.lang.Object, Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Message()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Message), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Message(@__env);
			}
		}
		internal Message(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6221;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Message._toString6221));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Message.staticClass, global::android.os.Message._toString6221));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getData6222;
		public global::android.os.Bundle getData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Message._getData6222));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Message.staticClass, global::android.os.Message._getData6222));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6223;
		public static global::android.os.Message obtain(android.os.Handler arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6224;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6225;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, java.lang.Object arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6226;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6227;
		public static global::android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3, java.lang.Object arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6228;
		public static global::android.os.Message obtain(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6229;
		public static global::android.os.Message obtain(android.os.Handler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6230;
		public static global::android.os.Message obtain() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, global::android.os.Message._obtain6230));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recycle6231;
		public void recycle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Message._recycle6231);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Message.staticClass, global::android.os.Message._recycle6231);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6232;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Message._writeToParcel6232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Message.staticClass, global::android.os.Message._writeToParcel6232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6233;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Message._describeContents6233);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Message.staticClass, global::android.os.Message._describeContents6233);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setData6234;
		public void setData(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Message._setData6234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Message.staticClass, global::android.os.Message._setData6234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallback6235;
		public global::java.lang.Runnable getCallback() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Runnable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Message._getCallback6235));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Runnable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Message.staticClass, global::android.os.Message._getCallback6235));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyFrom6236;
		public void copyFrom(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Message._copyFrom6236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Message.staticClass, global::android.os.Message._copyFrom6236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWhen6237;
		public long getWhen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.os.Message._getWhen6237);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.os.Message.staticClass, global::android.os.Message._getWhen6237);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTarget6238;
		public void setTarget(android.os.Handler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Message._setTarget6238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Message.staticClass, global::android.os.Message._setTarget6238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTarget6239;
		public global::android.os.Handler getTarget() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Message._getTarget6239));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Message.staticClass, global::android.os.Message._getTarget6239));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekData6240;
		public global::android.os.Bundle peekData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Message._peekData6240));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Message.staticClass, global::android.os.Message._peekData6240));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendToTarget6241;
		public void sendToTarget() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Message._sendToTarget6241);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Message.staticClass, global::android.os.Message._sendToTarget6241);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Message6242;
		public Message()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Message.staticClass, global::android.os.Message._Message6242, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _what6243;
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
		internal static global::net.sf.jni4net.jni.FieldId _arg16244;
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
		internal static global::net.sf.jni4net.jni.FieldId _arg26245;
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
		internal static global::net.sf.jni4net.jni.FieldId _obj6246;
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
		internal static global::net.sf.jni4net.jni.FieldId _replyTo6247;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR6248;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Message.staticClass = @__class;
			global::android.os.Message._toString6221 = @__env.GetMethodID(global::android.os.Message.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Message._getData6222 = @__env.GetMethodID(global::android.os.Message.staticClass, "getData", "()Landroid/os/Bundle;");
			global::android.os.Message._obtain6223 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;");
			global::android.os.Message._obtain6224 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;I)Landroid/os/Message;");
			global::android.os.Message._obtain6225 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain6226 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;III)Landroid/os/Message;");
			global::android.os.Message._obtain6227 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Message._obtain6228 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Message;)Landroid/os/Message;");
			global::android.os.Message._obtain6229 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;)Landroid/os/Message;");
			global::android.os.Message._obtain6230 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "()Landroid/os/Message;");
			global::android.os.Message._recycle6231 = @__env.GetMethodID(global::android.os.Message.staticClass, "recycle", "()V");
			global::android.os.Message._writeToParcel6232 = @__env.GetMethodID(global::android.os.Message.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Message._describeContents6233 = @__env.GetMethodID(global::android.os.Message.staticClass, "describeContents", "()I");
			global::android.os.Message._setData6234 = @__env.GetMethodID(global::android.os.Message.staticClass, "setData", "(Landroid/os/Bundle;)V");
			global::android.os.Message._getCallback6235 = @__env.GetMethodID(global::android.os.Message.staticClass, "getCallback", "()Ljava/lang/Runnable;");
			global::android.os.Message._copyFrom6236 = @__env.GetMethodID(global::android.os.Message.staticClass, "copyFrom", "(Landroid/os/Message;)V");
			global::android.os.Message._getWhen6237 = @__env.GetMethodID(global::android.os.Message.staticClass, "getWhen", "()J");
			global::android.os.Message._setTarget6238 = @__env.GetMethodID(global::android.os.Message.staticClass, "setTarget", "(Landroid/os/Handler;)V");
			global::android.os.Message._getTarget6239 = @__env.GetMethodID(global::android.os.Message.staticClass, "getTarget", "()Landroid/os/Handler;");
			global::android.os.Message._peekData6240 = @__env.GetMethodID(global::android.os.Message.staticClass, "peekData", "()Landroid/os/Bundle;");
			global::android.os.Message._sendToTarget6241 = @__env.GetMethodID(global::android.os.Message.staticClass, "sendToTarget", "()V");
			global::android.os.Message._Message6242 = @__env.GetMethodID(global::android.os.Message.staticClass, "<init>", "()V");
		}
	}
}
