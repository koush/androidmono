namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtocolVersion : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProtocolVersion(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.ProtocolVersion._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.ProtocolVersion.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.ProtocolVersion._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "hashCode", "()I", ref global::org.apache.http.ProtocolVersion._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.ProtocolVersion._m3) as java.lang.Object;
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.ProtocolVersion.staticClass, "getProtocol", "()Ljava/lang/String;", ref global::org.apache.http.ProtocolVersion._m4) as java.lang.String;
		}
		public new int Major
		{
			get
			{
				return getMajor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getMajor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "getMajor", "()I", ref global::org.apache.http.ProtocolVersion._m5);
		}
		public new int Minor
		{
			get
			{
				return getMinor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getMinor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "getMinor", "()I", ref global::org.apache.http.ProtocolVersion._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.ProtocolVersion forVersion(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "forVersion", "(II)Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.ProtocolVersion._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isComparable(org.apache.http.ProtocolVersion arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "isComparable", "(Lorg/apache/http/ProtocolVersion;)Z", ref global::org.apache.http.ProtocolVersion._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int compareToVersion(org.apache.http.ProtocolVersion arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "compareToVersion", "(Lorg/apache/http/ProtocolVersion;)I", ref global::org.apache.http.ProtocolVersion._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool greaterEquals(org.apache.http.ProtocolVersion arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "greaterEquals", "(Lorg/apache/http/ProtocolVersion;)Z", ref global::org.apache.http.ProtocolVersion._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool lessEquals(org.apache.http.ProtocolVersion arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, "lessEquals", "(Lorg/apache/http/ProtocolVersion;)Z", ref global::org.apache.http.ProtocolVersion._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public ProtocolVersion(java.lang.String arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.ProtocolVersion._m12.native == global::System.IntPtr.Zero)
				global::org.apache.http.ProtocolVersion._m12 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "<init>", "(Ljava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ProtocolVersion.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ProtocolVersion"));
		}
		internal static void InitJNI()
		{
		}
	}
}
