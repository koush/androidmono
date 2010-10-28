namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Boolean : java.lang.Object, java.io.Serializable, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Boolean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals19725;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._equals19725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._equals19725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19726;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Boolean._toString19726)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._toString19726)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19727;
		public static global::java.lang.String toString(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._toString19727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19728;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._hashCode19728);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._hashCode19728);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19729;
		public int compareTo(java.lang.Boolean arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo19729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo19729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19730;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Boolean._compareTo19730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._compareTo19730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean19731;
		public static bool getBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._getBoolean19731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19732;
		public static global::java.lang.Boolean valueOf(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf19732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19733;
		public static global::java.lang.Boolean valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._valueOf19733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _booleanValue19734;
		public bool booleanValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Boolean._booleanValue19734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Boolean.staticClass, global::java.lang.Boolean._booleanValue19734);
		}
		internal static global::MonoJavaBridge.MethodId _parseBoolean19735;
		public static bool parseBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._parseBoolean19735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Boolean19736;
		public Boolean(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean19736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Boolean19737;
		public Boolean(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._Boolean19737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TRUE19738;
		public static global::java.lang.Boolean TRUE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _TRUE19738)) as java.lang.Boolean;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FALSE19739;
		public static global::java.lang.Boolean FALSE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _FALSE19739)) as java.lang.Boolean;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE19740;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _TYPE19740)) as java.lang.Class;
			}
		}
		static Boolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Boolean.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Boolean"));
			global::java.lang.Boolean._equals19725 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Boolean._toString19726 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Boolean._toString19727 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "(Z)Ljava/lang/String;");
			global::java.lang.Boolean._hashCode19728 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "hashCode", "()I");
			global::java.lang.Boolean._compareTo19729 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Boolean;)I");
			global::java.lang.Boolean._compareTo19730 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Boolean._getBoolean19731 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._valueOf19732 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Z)Ljava/lang/Boolean;");
			global::java.lang.Boolean._valueOf19733 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			global::java.lang.Boolean._booleanValue19734 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "booleanValue", "()Z");
			global::java.lang.Boolean._parseBoolean19735 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "parseBoolean", "(Ljava/lang/String;)Z");
			global::java.lang.Boolean._Boolean19736 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Z)V");
			global::java.lang.Boolean._Boolean19737 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Boolean._TRUE19738 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "TRUE", "Ljava/lang/Boolean;");
			global::java.lang.Boolean._FALSE19739 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "FALSE", "Ljava/lang/Boolean;");
			global::java.lang.Boolean._TYPE19740 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
