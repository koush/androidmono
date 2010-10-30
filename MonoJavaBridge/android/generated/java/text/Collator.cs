namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.Collator_))]
	public abstract partial class Collator : java.lang.Object, java.util.Comparator, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Collator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25299;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._equals25299.native == global::System.IntPtr.Zero)
				global::java.text.Collator._equals25299 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._equals25299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals25300;
		public virtual bool equals(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._equals25300.native == global::System.IntPtr.Zero)
				global::java.text.Collator._equals25300 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "equals", "(Ljava/lang/String;Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._equals25300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25301;
		public abstract int hashCode();
		internal static global::MonoJavaBridge.MethodId _clone25302;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._clone25302.native == global::System.IntPtr.Zero)
				global::java.text.Collator._clone25302 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._clone25302) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compare25303;
		public abstract int compare(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _compare25304;
		public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._compare25304.native == global::System.IntPtr.Zero)
				global::java.text.Collator._compare25304 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._compare25304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25305;
		public static global::java.text.Collator getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._getInstance25305.native == global::System.IntPtr.Zero)
				global::java.text.Collator._getInstance25305 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getInstance", "()Ljava/text/Collator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._getInstance25305)) as java.text.Collator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25306;
		public static global::java.text.Collator getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._getInstance25306.native == global::System.IntPtr.Zero)
				global::java.text.Collator._getInstance25306 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._getInstance25306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.Collator;
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25307;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._getAvailableLocales25307.native == global::System.IntPtr.Zero)
				global::java.text.Collator._getAvailableLocales25307 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._getAvailableLocales25307)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey25308;
		public abstract global::java.text.CollationKey getCollationKey(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getDecomposition25309;
		public virtual int getDecomposition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._getDecomposition25309.native == global::System.IntPtr.Zero)
				global::java.text.Collator._getDecomposition25309 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "getDecomposition", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._getDecomposition25309);
		}
		internal static global::MonoJavaBridge.MethodId _getStrength25310;
		public virtual int getStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._getStrength25310.native == global::System.IntPtr.Zero)
				global::java.text.Collator._getStrength25310 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "getStrength", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._getStrength25310);
		}
		internal static global::MonoJavaBridge.MethodId _setStrength25311;
		public virtual void setStrength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._setStrength25311.native == global::System.IntPtr.Zero)
				global::java.text.Collator._setStrength25311 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "setStrength", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._setStrength25311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecomposition25312;
		public virtual void setDecomposition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._setDecomposition25312.native == global::System.IntPtr.Zero)
				global::java.text.Collator._setDecomposition25312 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "setDecomposition", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.Collator.staticClass, global::java.text.Collator._setDecomposition25312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Collator25313;
		protected Collator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._Collator25313.native == global::System.IntPtr.Zero)
				global::java.text.Collator._Collator25313 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Collator.staticClass, global::java.text.Collator._Collator25313);
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
		static Collator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Collator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Collator"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.Collator))]
	internal sealed partial class Collator_ : java.text.Collator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Collator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25321;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator_._hashCode25321.native == global::System.IntPtr.Zero)
				global::java.text.Collator_._hashCode25321 = @__env.GetMethodIDNoThrow(global::java.text.Collator_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.text.Collator_._hashCode25321);
		}
		internal static global::MonoJavaBridge.MethodId _compare25322;
		public override int compare(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator_._compare25322.native == global::System.IntPtr.Zero)
				global::java.text.Collator_._compare25322 = @__env.GetMethodIDNoThrow(global::java.text.Collator_.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.text.Collator_._compare25322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey25323;
		public override global::java.text.CollationKey getCollationKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator_._getCollationKey25323.native == global::System.IntPtr.Zero)
				global::java.text.Collator_._getCollationKey25323 = @__env.GetMethodIDNoThrow(global::java.text.Collator_.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Collator_._getCollationKey25323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationKey;
		}
		static Collator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Collator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Collator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
