namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetscapeDraftHeaderParser : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NetscapeDraftHeaderParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.HeaderElement parseHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, "parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/HeaderElement;", ref global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HeaderElement;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NetscapeDraftHeaderParser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._m1);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT7508;
		public static global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, _DEFAULT7508)) as org.apache.http.impl.cookie.NetscapeDraftHeaderParser;
			}
		}
		static NetscapeDraftHeaderParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/NetscapeDraftHeaderParser"));
			global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._DEFAULT7508 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, "DEFAULT", "Lorg/apache/http/impl/cookie/NetscapeDraftHeaderParser;");
		}
	}
}
