namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectStreamClass : java.lang.Object, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectStreamClass()
		{
			InitJNI();
		}
		protected ObjectStreamClass(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString13705;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._toString13705)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._toString13705)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName13706;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getName13706)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getName13706)) as java.lang.String;
		}
		public new global::java.io.ObjectStreamField[] Fields
		{
			get
			{
				return getFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFields13707;
		public virtual global::java.io.ObjectStreamField[] getFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.ObjectStreamField>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getFields13707)) as java.io.ObjectStreamField[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.ObjectStreamField>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getFields13707)) as java.io.ObjectStreamField[];
		}
		internal static global::MonoJavaBridge.MethodId _getField13708;
		public virtual global::java.io.ObjectStreamField getField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getField13708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getField13708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamField;
		}
		internal static global::MonoJavaBridge.MethodId _lookup13709;
		public static global::java.io.ObjectStreamClass lookup(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._lookup13709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		internal static global::MonoJavaBridge.MethodId _lookupAny13710;
		public static global::java.io.ObjectStreamClass lookupAny(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._lookupAny13710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		public new long SerialVersionUID
		{
			get
			{
				return getSerialVersionUID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSerialVersionUID13711;
		public virtual long getSerialVersionUID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getSerialVersionUID13711);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getSerialVersionUID13711);
		}
		internal static global::MonoJavaBridge.MethodId _forClass13712;
		public virtual global::java.lang.Class forClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._forClass13712)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._forClass13712)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.FieldId _NO_FIELDS13713;
		public static global::java.io.ObjectStreamField[] NO_FIELDS
		{
			get
			{
				return default(global::java.io.ObjectStreamField[]);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamClass"));
			global::java.io.ObjectStreamClass._toString13705 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.ObjectStreamClass._getName13706 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getName", "()Ljava/lang/String;");
			global::java.io.ObjectStreamClass._getFields13707 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getFields", "()[Ljava/io/ObjectStreamField;");
			global::java.io.ObjectStreamClass._getField13708 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;");
			global::java.io.ObjectStreamClass._lookup13709 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			global::java.io.ObjectStreamClass._lookupAny13710 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			global::java.io.ObjectStreamClass._getSerialVersionUID13711 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getSerialVersionUID", "()J");
			global::java.io.ObjectStreamClass._forClass13712 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "forClass", "()Ljava/lang/Class;");
		}
	}
}
