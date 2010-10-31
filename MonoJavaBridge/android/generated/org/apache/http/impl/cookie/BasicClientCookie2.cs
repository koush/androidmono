namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicClientCookie2 : org.apache.http.impl.cookie.BasicClientCookie, org.apache.http.cookie.SetCookie2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicClientCookie2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "isPersistent", "()Z", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m1);
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
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m2) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m3;
		public override int[] getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "getPorts", "()[I", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m3) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setCommentURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setCommentURL", "(Ljava/lang/String;)V", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setPorts(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setPorts", "([I)V", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Discard
		{
			set
			{
				setDiscard(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setDiscard(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setDiscard", "(Z)V", ref global::org.apache.http.impl.cookie.BasicClientCookie2._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public BasicClientCookie2(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.BasicClientCookie2._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.BasicClientCookie2._m8 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicClientCookie2()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicClientCookie2"));
		}
	}
}
