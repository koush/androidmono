namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetscapeDraftHeaderParser : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NetscapeDraftHeaderParser()
		{
			InitJNI();
		}
		protected NetscapeDraftHeaderParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseHeader33310;
		public virtual global::org.apache.http.HeaderElement parseHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._parseHeader33310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._parseHeader33310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDraftHeaderParser33311;
		public NetscapeDraftHeaderParser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._NetscapeDraftHeaderParser33311);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT33312;
		public static global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, _DEFAULT33312)) as org.apache.http.impl.cookie.NetscapeDraftHeaderParser;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/NetscapeDraftHeaderParser"));
			global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._parseHeader33310 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, "parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._NetscapeDraftHeaderParser33311 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, "<init>", "()V");
			global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser._DEFAULT33312 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftHeaderParser.staticClass, "DEFAULT", "Lorg/apache/http/impl/cookie/NetscapeDraftHeaderParser;");
		}
	}
}
