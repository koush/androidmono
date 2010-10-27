namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.Collator_))]
	public abstract partial class Collator : java.lang.Object, java.util.Comparator, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Collator()
		{
			InitJNI();
		}
		protected Collator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25298;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Collator._equals25298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._equals25298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals25299;
		public virtual bool equals(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.Collator._equals25299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._equals25299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25300;
		public abstract int hashCode();
		internal static global::MonoJavaBridge.MethodId _clone25301;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Collator._clone25301)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._clone25301)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compare25302;
		public abstract int compare(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _compare25303;
		public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Collator._compare25303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._compare25303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25304;
		public static global::java.text.Collator getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._getInstance25304)) as java.text.Collator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25305;
		public static global::java.text.Collator getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._getInstance25305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.Collator;
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25306;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._getAvailableLocales25306)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey25307;
		public abstract global::java.text.CollationKey getCollationKey(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getDecomposition25308;
		public virtual int getDecomposition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Collator._getDecomposition25308);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._getDecomposition25308);
		}
		internal static global::MonoJavaBridge.MethodId _getStrength25309;
		public virtual int getStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Collator._getStrength25309);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._getStrength25309);
		}
		internal static global::MonoJavaBridge.MethodId _setStrength25310;
		public virtual void setStrength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.Collator._setStrength25310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._setStrength25310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecomposition25311;
		public virtual void setDecomposition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.Collator._setDecomposition25311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.Collator.staticClass, global::java.text.Collator._setDecomposition25311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Collator25312;
		protected Collator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Collator.staticClass, global::java.text.Collator._Collator25312);
			Init(@__env, handle);
		}
		public static int PRIMARY
		{
			get
			{
				return 0;
			}
		}
		public static int SECONDARY
		{
			get
			{
				return 1;
			}
		}
		public static int TERTIARY
		{
			get
			{
				return 2;
			}
		}
		public static int IDENTICAL
		{
			get
			{
				return 3;
			}
		}
		public static int NO_DECOMPOSITION
		{
			get
			{
				return 0;
			}
		}
		public static int CANONICAL_DECOMPOSITION
		{
			get
			{
				return 1;
			}
		}
		public static int FULL_DECOMPOSITION
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Collator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Collator"));
			global::java.text.Collator._equals25298 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.Collator._equals25299 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "equals", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::java.text.Collator._hashCode25300 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "hashCode", "()I");
			global::java.text.Collator._clone25301 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.Collator._compare25302 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::java.text.Collator._compare25303 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			global::java.text.Collator._getInstance25304 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getInstance", "()Ljava/text/Collator;");
			global::java.text.Collator._getInstance25305 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;");
			global::java.text.Collator._getAvailableLocales25306 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.Collator._getCollationKey25307 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;");
			global::java.text.Collator._getDecomposition25308 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "getDecomposition", "()I");
			global::java.text.Collator._getStrength25309 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "getStrength", "()I");
			global::java.text.Collator._setStrength25310 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "setStrength", "(I)V");
			global::java.text.Collator._setDecomposition25311 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "setDecomposition", "(I)V");
			global::java.text.Collator._Collator25312 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.Collator))]
	internal sealed partial class Collator_ : java.text.Collator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Collator_()
		{
			InitJNI();
		}
		internal Collator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25320;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Collator_._hashCode25320);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Collator_.staticClass, global::java.text.Collator_._hashCode25320);
		}
		internal static global::MonoJavaBridge.MethodId _compare25321;
		public override int compare(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.Collator_._compare25321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.Collator_.staticClass, global::java.text.Collator_._compare25321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey25322;
		public override global::java.text.CollationKey getCollationKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Collator_._getCollationKey25322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.Collator_.staticClass, global::java.text.Collator_._getCollationKey25322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Collator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Collator"));
			global::java.text.Collator_._hashCode25320 = @__env.GetMethodIDNoThrow(global::java.text.Collator_.staticClass, "hashCode", "()I");
			global::java.text.Collator_._compare25321 = @__env.GetMethodIDNoThrow(global::java.text.Collator_.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::java.text.Collator_._getCollationKey25322 = @__env.GetMethodIDNoThrow(global::java.text.Collator_.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;");
		}
	}
}
