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
		internal static global::MonoJavaBridge.MethodId _toString19180;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._toString19180)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._toString19180)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName19181;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getName19181)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getName19181)) as java.lang.String;
		}
		public new global::java.io.ObjectStreamField[] Fields
		{
			get
			{
				return getFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFields19182;
		public virtual global::java.io.ObjectStreamField[] getFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.ObjectStreamField>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getFields19182)) as java.io.ObjectStreamField[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.ObjectStreamField>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getFields19182)) as java.io.ObjectStreamField[];
		}
		internal static global::MonoJavaBridge.MethodId _getField19183;
		public virtual global::java.io.ObjectStreamField getField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getField19183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getField19183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamField;
		}
		internal static global::MonoJavaBridge.MethodId _lookup19184;
		public static global::java.io.ObjectStreamClass lookup(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._lookup19184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		internal static global::MonoJavaBridge.MethodId _lookupAny19185;
		public static global::java.io.ObjectStreamClass lookupAny(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._lookupAny19185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.ObjectStreamClass;
		}
		public new long SerialVersionUID
		{
			get
			{
				return getSerialVersionUID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSerialVersionUID19186;
		public virtual long getSerialVersionUID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectStreamClass._getSerialVersionUID19186);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._getSerialVersionUID19186);
		}
		internal static global::MonoJavaBridge.MethodId _forClass19187;
		public virtual global::java.lang.Class forClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass._forClass19187)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamClass.staticClass, global::java.io.ObjectStreamClass._forClass19187)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.FieldId _NO_FIELDS19188;
		public static global::java.io.ObjectStreamField[] NO_FIELDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.ObjectStreamField>(@__env.GetStaticObjectField(global::java.io.ObjectStreamClass.staticClass, _NO_FIELDS19188)) as java.io.ObjectStreamField[];
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamClass"));
			global::java.io.ObjectStreamClass._toString19180 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.ObjectStreamClass._getName19181 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getName", "()Ljava/lang/String;");
			global::java.io.ObjectStreamClass._getFields19182 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getFields", "()[Ljava/io/ObjectStreamField;");
			global::java.io.ObjectStreamClass._getField19183 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;");
			global::java.io.ObjectStreamClass._lookup19184 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			global::java.io.ObjectStreamClass._lookupAny19185 = @__env.GetStaticMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;");
			global::java.io.ObjectStreamClass._getSerialVersionUID19186 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "getSerialVersionUID", "()J");
			global::java.io.ObjectStreamClass._forClass19187 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "forClass", "()Ljava/lang/Class;");
			global::java.io.ObjectStreamClass._NO_FIELDS19188 = @__env.GetStaticFieldIDNoThrow(global::java.io.ObjectStreamClass.staticClass, "NO_FIELDS", "[Ljava/io/ObjectStreamField;");
		}
	}
}
