namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.CollationKey_))]
	public abstract partial class CollationKey : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CollationKey(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25292;
		public abstract int compareTo(java.text.CollationKey arg0);
		internal static global::MonoJavaBridge.MethodId _compareTo25293;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationKey.staticClass, global::java.text.CollationKey._compareTo25293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray25294;
		public abstract byte[] toByteArray();
		internal static global::MonoJavaBridge.MethodId _getSourceString25295;
		public virtual global::java.lang.String getSourceString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.CollationKey.staticClass, global::java.text.CollationKey._getSourceString25295)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CollationKey25296;
		protected CollationKey(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.CollationKey.staticClass, global::java.text.CollationKey._CollationKey25296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CollationKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CollationKey.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CollationKey"));
			global::java.text.CollationKey._compareTo25292 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "compareTo", "(Ljava/text/CollationKey;)I");
			global::java.text.CollationKey._compareTo25293 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.text.CollationKey._toByteArray25294 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "toByteArray", "()[B");
			global::java.text.CollationKey._getSourceString25295 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "getSourceString", "()Ljava/lang/String;");
			global::java.text.CollationKey._CollationKey25296 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.CollationKey))]
	internal sealed partial class CollationKey_ : java.text.CollationKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CollationKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25297;
		public override int compareTo(java.text.CollationKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationKey_._compareTo25297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray25298;
		public override byte[] toByteArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.CollationKey_._toByteArray25298)) as byte[];
		}
		static CollationKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CollationKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CollationKey"));
			global::java.text.CollationKey_._compareTo25297 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey_.staticClass, "compareTo", "(Ljava/text/CollationKey;)I");
			global::java.text.CollationKey_._toByteArray25298 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey_.staticClass, "toByteArray", "()[B");
		}
		internal static void InitJNI()
		{
		}
	}
}
