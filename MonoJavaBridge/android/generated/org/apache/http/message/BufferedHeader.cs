namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedHeader : java.lang.Object, FormattedHeader, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedHeader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BufferedHeader.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.message.BufferedHeader._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BufferedHeader.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.message.BufferedHeader._m1) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BufferedHeader.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.message.BufferedHeader._m2) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BufferedHeader.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.message.BufferedHeader._m3) as java.lang.String;
		}
		public new global::org.apache.http.HeaderElement[] Elements
		{
			get
			{
				return getElements();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.HeaderElement[] getElements()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BufferedHeader.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BufferedHeader._m4) as org.apache.http.HeaderElement[];
		}
		public new global::org.apache.http.util.CharArrayBuffer Buffer
		{
			get
			{
				return getBuffer();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.util.CharArrayBuffer getBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BufferedHeader.staticClass, "getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BufferedHeader._m5) as org.apache.http.util.CharArrayBuffer;
		}
		public new int ValuePos
		{
			get
			{
				return getValuePos();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getValuePos()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BufferedHeader.staticClass, "getValuePos", "()I", ref global::org.apache.http.message.BufferedHeader._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public BufferedHeader(org.apache.http.util.CharArrayBuffer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BufferedHeader._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BufferedHeader._m7 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BufferedHeader.staticClass, "<init>", "(Lorg/apache/http/util/CharArrayBuffer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BufferedHeader.staticClass, global::org.apache.http.message.BufferedHeader._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BufferedHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BufferedHeader.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BufferedHeader"));
		}
	}
}
