namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicClientCookie2 : org.apache.http.impl.cookie.BasicClientCookie, org.apache.http.cookie.SetCookie2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicClientCookie2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone33242;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._clone33242)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent33243;
		public override bool isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._isPersistent33243);
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
		internal static global::MonoJavaBridge.MethodId _getCommentURL33244;
		public override global::java.lang.String getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._getCommentURL33244)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getPorts33245;
		public override int[] getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._getPorts33245)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired33246;
		public override bool isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._isExpired33246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCommentURL33247;
		public virtual void setCommentURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._setCommentURL33247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPorts33248;
		public virtual void setPorts(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._setPorts33248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Discard
		{
			set
			{
				setDiscard(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDiscard33249;
		public virtual void setDiscard(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._setDiscard33249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicClientCookie233250;
		public BasicClientCookie2(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicClientCookie2.staticClass, global::org.apache.http.impl.cookie.BasicClientCookie2._BasicClientCookie233250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicClientCookie2()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicClientCookie2"));
			global::org.apache.http.impl.cookie.BasicClientCookie2._clone33242 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.impl.cookie.BasicClientCookie2._isPersistent33243 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "isPersistent", "()Z");
			global::org.apache.http.impl.cookie.BasicClientCookie2._getCommentURL33244 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.impl.cookie.BasicClientCookie2._getPorts33245 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "getPorts", "()[I");
			global::org.apache.http.impl.cookie.BasicClientCookie2._isExpired33246 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "isExpired", "(Ljava/util/Date;)Z");
			global::org.apache.http.impl.cookie.BasicClientCookie2._setCommentURL33247 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setCommentURL", "(Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicClientCookie2._setPorts33248 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setPorts", "([I)V");
			global::org.apache.http.impl.cookie.BasicClientCookie2._setDiscard33249 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "setDiscard", "(Z)V");
			global::org.apache.http.impl.cookie.BasicClientCookie2._BasicClientCookie233250 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicClientCookie2.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
