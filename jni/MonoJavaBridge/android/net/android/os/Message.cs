namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Message : java.lang.Object, Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Message() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Message), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString5379; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString5379)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Message.staticClass, _toString5379)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getData5380; 
		public android.os.Bundle getData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getData5380)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Message.staticClass, _getData5380)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5381; 
		public static android.os.Message obtain(android.os.Handler arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5382; 
		public static android.os.Message obtain(android.os.Handler arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5383; 
		public static android.os.Message obtain(android.os.Handler arg0, int arg1, java.lang.Object arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5384; 
		public static android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5385; 
		public static android.os.Message obtain(android.os.Handler arg0, int arg1, int arg2, int arg3, java.lang.Object arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5386; 
		public static android.os.Message obtain(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5387; 
		public static android.os.Message obtain(android.os.Handler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5388; 
		public static android.os.Message obtain() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Message.staticClass, _obtain5388)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle5389; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				@__env.CallVoidMethod(this, _recycle5389); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Message.staticClass, _recycle5389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5390; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				@__env.CallVoidMethod(this, _writeToParcel5390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Message.staticClass, _writeToParcel5390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5391; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				return @__env.CallIntMethod(this, _describeContents5391); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Message.staticClass, _describeContents5391); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setData5392; 
		public void setData(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				@__env.CallVoidMethod(this, _setData5392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Message.staticClass, _setData5392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallback5393; 
		public java.lang.Runnable getCallback() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Runnable>(@__env, @__env.CallObjectMethodPtr(this, _getCallback5393)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Runnable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Message.staticClass, _getCallback5393)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyFrom5394; 
		public void copyFrom(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				@__env.CallVoidMethod(this, _copyFrom5394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Message.staticClass, _copyFrom5394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWhen5395; 
		public long getWhen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				return @__env.CallLongMethod(this, _getWhen5395); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.os.Message.staticClass, _getWhen5395); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTarget5396; 
		public void setTarget(android.os.Handler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				@__env.CallVoidMethod(this, _setTarget5396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Message.staticClass, _setTarget5396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTarget5397; 
		public android.os.Handler getTarget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallObjectMethodPtr(this, _getTarget5397)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Message.staticClass, _getTarget5397)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekData5398; 
		public android.os.Bundle peekData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _peekData5398)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Message.staticClass, _peekData5398)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendToTarget5399; 
		public void sendToTarget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Message)) 
				@__env.CallVoidMethod(this, _sendToTarget5399); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Message.staticClass, _sendToTarget5399); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Message5400; 
		public Message()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Message.staticClass, _Message5400, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _what5401; 
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
		internal static global::net.sf.jni4net.jni.FieldId _arg15402; 
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
		internal static global::net.sf.jni4net.jni.FieldId _arg25403; 
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
		internal static global::net.sf.jni4net.jni.FieldId _obj5404; 
		public java.lang.Object obj
		{ 
			get 
			{ 
				return default(java.lang.Object); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _replyTo5405; 
		public android.os.Messenger replyTo
		{ 
			get 
			{ 
				return default(android.os.Messenger); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5406; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Message.staticClass = @__class; 
			global::android.os.Message._toString5379 = @__env.GetMethodID(global::android.os.Message.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.os.Message._getData5380 = @__env.GetMethodID(global::android.os.Message.staticClass, "getData", "()Landroid/os/Bundle;"); 
			global::android.os.Message._obtain5381 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;"); 
			global::android.os.Message._obtain5382 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;I)Landroid/os/Message;"); 
			global::android.os.Message._obtain5383 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;ILjava/lang/Object;)Landroid/os/Message;"); 
			global::android.os.Message._obtain5384 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;III)Landroid/os/Message;"); 
			global::android.os.Message._obtain5385 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;IIILjava/lang/Object;)Landroid/os/Message;"); 
			global::android.os.Message._obtain5386 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Message;)Landroid/os/Message;"); 
			global::android.os.Message._obtain5387 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "(Landroid/os/Handler;)Landroid/os/Message;"); 
			global::android.os.Message._obtain5388 = @__env.GetStaticMethodID(global::android.os.Message.staticClass, "obtain", "()Landroid/os/Message;"); 
			global::android.os.Message._recycle5389 = @__env.GetMethodID(global::android.os.Message.staticClass, "recycle", "()V"); 
			global::android.os.Message._writeToParcel5390 = @__env.GetMethodID(global::android.os.Message.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.os.Message._describeContents5391 = @__env.GetMethodID(global::android.os.Message.staticClass, "describeContents", "()I"); 
			global::android.os.Message._setData5392 = @__env.GetMethodID(global::android.os.Message.staticClass, "setData", "(Landroid/os/Bundle;)V"); 
			global::android.os.Message._getCallback5393 = @__env.GetMethodID(global::android.os.Message.staticClass, "getCallback", "()Ljava/lang/Runnable;"); 
			global::android.os.Message._copyFrom5394 = @__env.GetMethodID(global::android.os.Message.staticClass, "copyFrom", "(Landroid/os/Message;)V"); 
			global::android.os.Message._getWhen5395 = @__env.GetMethodID(global::android.os.Message.staticClass, "getWhen", "()J"); 
			global::android.os.Message._setTarget5396 = @__env.GetMethodID(global::android.os.Message.staticClass, "setTarget", "(Landroid/os/Handler;)V"); 
			global::android.os.Message._getTarget5397 = @__env.GetMethodID(global::android.os.Message.staticClass, "getTarget", "()Landroid/os/Handler;"); 
			global::android.os.Message._peekData5398 = @__env.GetMethodID(global::android.os.Message.staticClass, "peekData", "()Landroid/os/Bundle;"); 
			global::android.os.Message._sendToTarget5399 = @__env.GetMethodID(global::android.os.Message.staticClass, "sendToTarget", "()V"); 
			global::android.os.Message._Message5400 = @__env.GetMethodID(global::android.os.Message.staticClass, "<init>", "()V"); 
		} 
	} 
} 
