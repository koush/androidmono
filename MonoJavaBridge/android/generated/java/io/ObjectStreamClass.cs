namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectStreamClass : java.lang.Object, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ObjectStreamClass(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectStreamClass.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.ObjectStreamClass._m0) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectStreamClass.staticClass, "getName", "()Ljava/lang/String;", ref global::java.io.ObjectStreamClass._m1) as java.lang.String;
		}
		public new global::java.io.ObjectStreamField[] Fields
		{
			get
			{
				return getFields();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.io.ObjectStreamField[] getFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.io.ObjectStreamField>(this, global::java.io.ObjectStreamClass.staticClass, "getFields", "()[Ljava/io/ObjectStreamField;", ref global::java.io.ObjectStreamClass._m2) as java.io.ObjectStreamField[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.io.ObjectStreamField getField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectStreamClass.staticClass, "getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;", ref global::java.io.ObjectStreamClass._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.ObjectStreamField;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.io.ObjectStreamClass lookup(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamClass._m4.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamClass._m4 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.io.ObjectStreamClass lookupAny(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamClass._m5.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamClass._m5 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		public new long SerialVersionUID
		{
			get
			{
				return getSerialVersionUID();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long getSerialVersionUID()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectStreamClass.staticClass, "getSerialVersionUID", "()J", ref global::java.io.ObjectStreamClass._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Class forClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.io.ObjectStreamClass.staticClass, "forClass", "()Ljava/lang/Class;", ref global::java.io.ObjectStreamClass._m7) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.FieldId _NO_FIELDS6201;
		public static global::java.io.ObjectStreamField[] NO_FIELDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.ObjectStreamField>(@__env.GetStaticObjectField(global::java.io.ObjectStreamClass.staticClass, _NO_FIELDS6201)) as java.io.ObjectStreamField[];
			}
		}
		static ObjectStreamClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamClass"));
			global::java.io.ObjectStreamClass._NO_FIELDS6201 = @__env.GetStaticFieldIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "NO_FIELDS", "[Ljava/io/ObjectStreamField;");
		}
	}
}
