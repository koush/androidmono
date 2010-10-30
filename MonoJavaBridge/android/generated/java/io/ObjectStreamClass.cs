namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectStreamClass : java.lang.Object, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ObjectStreamClass(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19298;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectStreamClass.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.ObjectStreamClass._toString19298) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName19299;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectStreamClass.staticClass, "getName", "()Ljava/lang/String;", ref global::java.io.ObjectStreamClass._getName19299) as java.lang.String;
		}
		public new global::java.io.ObjectStreamField[] Fields
		{
			get
			{
				return getFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFields19300;
		public virtual global::java.io.ObjectStreamField[] getFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.io.ObjectStreamField>(this, global::java.io.ObjectStreamClass.staticClass, "getFields", "()[Ljava/io/ObjectStreamField;", ref global::java.io.ObjectStreamClass._getFields19300) as java.io.ObjectStreamField[];
		}
		internal static global::MonoJavaBridge.MethodId _getField19301;
		public virtual global::java.io.ObjectStreamField getField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectStreamClass.staticClass, "getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;", ref global::java.io.ObjectStreamClass._getField19301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.ObjectStreamField;
		}
		internal static global::MonoJavaBridge.MethodId _lookup19302;
		public static global::java.io.ObjectStreamClass lookup(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamClass._lookup19302.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamClass._lookup19302 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._lookup19302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		internal static global::MonoJavaBridge.MethodId _lookupAny19303;
		public static global::java.io.ObjectStreamClass lookupAny(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamClass._lookupAny19303.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamClass._lookupAny19303 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._lookupAny19303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		public new long SerialVersionUID
		{
			get
			{
				return getSerialVersionUID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSerialVersionUID19304;
		public virtual long getSerialVersionUID()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectStreamClass.staticClass, "getSerialVersionUID", "()J", ref global::java.io.ObjectStreamClass._getSerialVersionUID19304);
		}
		internal static global::MonoJavaBridge.MethodId _forClass19305;
		public virtual global::java.lang.Class forClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.io.ObjectStreamClass.staticClass, "forClass", "()Ljava/lang/Class;", ref global::java.io.ObjectStreamClass._forClass19305) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.FieldId _NO_FIELDS19306;
		public static global::java.io.ObjectStreamField[] NO_FIELDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.ObjectStreamField>(@__env.GetStaticObjectField(global::java.io.ObjectStreamClass.staticClass, _NO_FIELDS19306)) as java.io.ObjectStreamField[];
			}
		}
		static ObjectStreamClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamClass"));
			global::java.io.ObjectStreamClass._NO_FIELDS19306 = @__env.GetStaticFieldIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "NO_FIELDS", "[Ljava/io/ObjectStreamField;");
		}
		internal static void InitJNI()
		{
		}
	}
}
