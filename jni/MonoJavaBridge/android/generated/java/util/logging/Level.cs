namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Level : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Level()
		{
			InitJNI();
		}
		protected Level(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals27977;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Level._equals27977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._equals27977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27978;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._toString27978)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._toString27978)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27979;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._hashCode27979);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._hashCode27979);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName27980;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getName27980)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getName27980)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _intValue27981;
		public virtual int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._intValue27981);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._intValue27981);
		}
		internal static global::MonoJavaBridge.MethodId _parse27982;
		public static global::java.util.logging.Level parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Level.staticClass, global::java.util.logging.Level._parse27982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Level;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundleName27983;
		public virtual global::java.lang.String getResourceBundleName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getResourceBundleName27983)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getResourceBundleName27983)) as java.lang.String;
		}
		public new global::java.lang.String LocalizedName
		{
			get
			{
				return getLocalizedName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedName27984;
		public virtual global::java.lang.String getLocalizedName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getLocalizedName27984)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getLocalizedName27984)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Level27985;
		protected Level(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level27985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Level27986;
		protected Level(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level27986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _OFF27987;
		public static global::java.util.logging.Level OFF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _OFF27987)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEVERE27988;
		public static global::java.util.logging.Level SEVERE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _SEVERE27988)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _WARNING27989;
		public static global::java.util.logging.Level WARNING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _WARNING27989)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INFO27990;
		public static global::java.util.logging.Level INFO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _INFO27990)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONFIG27991;
		public static global::java.util.logging.Level CONFIG
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _CONFIG27991)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINE27992;
		public static global::java.util.logging.Level FINE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINE27992)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINER27993;
		public static global::java.util.logging.Level FINER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINER27993)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINEST27994;
		public static global::java.util.logging.Level FINEST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINEST27994)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALL27995;
		public static global::java.util.logging.Level ALL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _ALL27995)) as java.util.logging.Level;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Level.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Level"));
			global::java.util.logging.Level._equals27977 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.logging.Level._toString27978 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.logging.Level._hashCode27979 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "hashCode", "()I");
			global::java.util.logging.Level._getName27980 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.logging.Level._intValue27981 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "intValue", "()I");
			global::java.util.logging.Level._parse27982 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Level.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/logging/Level;");
			global::java.util.logging.Level._getResourceBundleName27983 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getResourceBundleName", "()Ljava/lang/String;");
			global::java.util.logging.Level._getLocalizedName27984 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getLocalizedName", "()Ljava/lang/String;");
			global::java.util.logging.Level._Level27985 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.util.logging.Level._Level27986 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.util.logging.Level._OFF27987 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "OFF", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._SEVERE27988 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "SEVERE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._WARNING27989 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "WARNING", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._INFO27990 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "INFO", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._CONFIG27991 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "CONFIG", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINE27992 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINER27993 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINER", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINEST27994 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINEST", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._ALL27995 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "ALL", "Ljava/util/logging/Level;");
		}
	}
}
