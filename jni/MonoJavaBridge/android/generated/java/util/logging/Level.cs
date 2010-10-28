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
		internal static global::MonoJavaBridge.MethodId _equals27978;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Level._equals27978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._equals27978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27979;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._toString27979)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._toString27979)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27980;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._hashCode27980);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._hashCode27980);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName27981;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getName27981)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getName27981)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _intValue27982;
		public virtual int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.Level._intValue27982);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._intValue27982);
		}
		internal static global::MonoJavaBridge.MethodId _parse27983;
		public static global::java.util.logging.Level parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.logging.Level.staticClass, global::java.util.logging.Level._parse27983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.logging.Level;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundleName27984;
		public virtual global::java.lang.String getResourceBundleName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getResourceBundleName27984)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getResourceBundleName27984)) as java.lang.String;
		}
		public new global::java.lang.String LocalizedName
		{
			get
			{
				return getLocalizedName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedName27985;
		public virtual global::java.lang.String getLocalizedName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Level._getLocalizedName27985)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Level.staticClass, global::java.util.logging.Level._getLocalizedName27985)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Level27986;
		protected Level(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level27986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Level27987;
		protected Level(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Level.staticClass, global::java.util.logging.Level._Level27987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _OFF27988;
		public static global::java.util.logging.Level OFF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _OFF27988)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SEVERE27989;
		public static global::java.util.logging.Level SEVERE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _SEVERE27989)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _WARNING27990;
		public static global::java.util.logging.Level WARNING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _WARNING27990)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INFO27991;
		public static global::java.util.logging.Level INFO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _INFO27991)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CONFIG27992;
		public static global::java.util.logging.Level CONFIG
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _CONFIG27992)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINE27993;
		public static global::java.util.logging.Level FINE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINE27993)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINER27994;
		public static global::java.util.logging.Level FINER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINER27994)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINEST27995;
		public static global::java.util.logging.Level FINEST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _FINEST27995)) as java.util.logging.Level;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALL27996;
		public static global::java.util.logging.Level ALL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.logging.Level.staticClass, _ALL27996)) as java.util.logging.Level;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Level.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Level"));
			global::java.util.logging.Level._equals27978 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.logging.Level._toString27979 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.logging.Level._hashCode27980 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "hashCode", "()I");
			global::java.util.logging.Level._getName27981 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.logging.Level._intValue27982 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "intValue", "()I");
			global::java.util.logging.Level._parse27983 = @__env.GetStaticMethodIDNoThrow(global::java.util.logging.Level.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/logging/Level;");
			global::java.util.logging.Level._getResourceBundleName27984 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getResourceBundleName", "()Ljava/lang/String;");
			global::java.util.logging.Level._getLocalizedName27985 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "getLocalizedName", "()Ljava/lang/String;");
			global::java.util.logging.Level._Level27986 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.util.logging.Level._Level27987 = @__env.GetMethodIDNoThrow(global::java.util.logging.Level.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.util.logging.Level._OFF27988 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "OFF", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._SEVERE27989 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "SEVERE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._WARNING27990 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "WARNING", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._INFO27991 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "INFO", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._CONFIG27992 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "CONFIG", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINE27993 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINE", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINER27994 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINER", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._FINEST27995 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "FINEST", "Ljava/util/logging/Level;");
			global::java.util.logging.Level._ALL27996 = @__env.GetStaticFieldIDNoThrow(global::java.util.logging.Level.staticClass, "ALL", "Ljava/util/logging/Level;");
		}
	}
}
