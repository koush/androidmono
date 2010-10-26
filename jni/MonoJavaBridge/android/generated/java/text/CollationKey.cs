namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.CollationKey_))]
	public abstract partial class CollationKey : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CollationKey()
		{
			InitJNI();
		}
		protected CollationKey(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25291;
		public abstract int compareTo(java.text.CollationKey arg0);
		internal static global::MonoJavaBridge.MethodId _compareTo25292;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationKey._compareTo25292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationKey.staticClass, global::java.text.CollationKey._compareTo25292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray25293;
		public abstract byte[] toByteArray();
		internal static global::MonoJavaBridge.MethodId _getSourceString25294;
		public virtual global::java.lang.String getSourceString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.CollationKey._getSourceString25294)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.CollationKey.staticClass, global::java.text.CollationKey._getSourceString25294)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CollationKey25295;
		protected CollationKey(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.CollationKey.staticClass, global::java.text.CollationKey._CollationKey25295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CollationKey.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CollationKey"));
			global::java.text.CollationKey._compareTo25291 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "compareTo", "(Ljava/text/CollationKey;)I");
			global::java.text.CollationKey._compareTo25292 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.text.CollationKey._toByteArray25293 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "toByteArray", "()[B");
			global::java.text.CollationKey._getSourceString25294 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "getSourceString", "()Ljava/lang/String;");
			global::java.text.CollationKey._CollationKey25295 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.CollationKey))]
	internal sealed partial class CollationKey_ : java.text.CollationKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CollationKey_()
		{
			InitJNI();
		}
		internal CollationKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25296;
		public override int compareTo(java.text.CollationKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CollationKey_._compareTo25296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CollationKey_.staticClass, global::java.text.CollationKey_._compareTo25296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray25297;
		public override byte[] toByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.CollationKey_._toByteArray25297)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.CollationKey_.staticClass, global::java.text.CollationKey_._toByteArray25297)) as byte[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CollationKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CollationKey"));
			global::java.text.CollationKey_._compareTo25296 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey_.staticClass, "compareTo", "(Ljava/text/CollationKey;)I");
			global::java.text.CollationKey_._toByteArray25297 = @__env.GetMethodIDNoThrow(global::java.text.CollationKey_.staticClass, "toByteArray", "()[B");
		}
	}
}
