namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicClientCookie2 : org.apache.http.impl.cookie.BasicClientCookie, org.apache.http.cookie.SetCookie2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicClientCookie2()
		{
			InitJNI();
		}
		protected BasicClientCookie2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone26499;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._clone26499)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._clone26499)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent26500;
		public override bool isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._isPersistent26500);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._isPersistent26500);
		}
		public new global::java.lang.String CommentURL
		{
			get
			{
				return getCommentURL();
			}
			set
			{
				setCommentURL(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL26501;
		public override global::java.lang.String getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._getCommentURL26501)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._getCommentURL26501)) as java.lang.String;
		}
		public new int[] Ports
		{
			get
			{
				return getPorts();
			}
			set
			{
				setPorts(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPorts26502;
		public override int[] getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._getPorts26502)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._getPorts26502)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired26503;
		public override bool isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._isExpired26503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._isExpired26503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCommentURL26504;
		public virtual void setCommentURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._setCommentURL26504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._setCommentURL26504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPorts26505;
		public virtual void setPorts(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._setPorts26505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._setPorts26505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDiscard26506;
		public virtual void setDiscard(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2._setDiscard26506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._setDiscard26506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicClientCookie226507;
		public BasicClientCookie2(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._BasicClientCookie226507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicClientCookie2"));
			global::org.apache.http.impl.cookie.BasicClientCookie2._clone26499 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.impl.cookie.BasicClientCookie2._isPersistent26500 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "isPersistent", "()Z");
			global::org.apache.http.impl.cookie.BasicClientCookie2._getCommentURL26501 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie2._getPorts26502 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "getPorts", "()[I");
			global::org.apache.http.impl.cookie.BasicClientCookie2._isExpired26503 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "isExpired", "(Ljava/util/Date;)Z");
			global::org.apache.http.impl.cookie.BasicClientCookie2._setCommentURL26504 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setCommentURL", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie2._setPorts26505 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setPorts", "([I)V");
			global::org.apache.http.impl.cookie.BasicClientCookie2._setDiscard26506 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setDiscard", "(Z)V");
			global::org.apache.http.impl.cookie.BasicClientCookie2._BasicClientCookie226507 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
