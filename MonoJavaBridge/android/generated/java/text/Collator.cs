namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.Collator_))]
	public abstract partial class Collator : java.lang.Object, java.util.Comparator, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Collator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Collator.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.Collator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool equals(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Collator.staticClass, "equals", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::java.text.Collator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int hashCode();
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Collator.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.Collator._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract int compare(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", ref global::java.text.Collator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.text.Collator getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._m6.native == global::System.IntPtr.Zero)
				global::java.text.Collator._m6 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getInstance", "()Ljava/text/Collator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._m6)) as java.text.Collator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.text.Collator getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._m7.native == global::System.IntPtr.Zero)
				global::java.text.Collator._m7 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.Collator;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._m8.native == global::System.IntPtr.Zero)
				global::java.text.Collator._m8 = @__env.GetStaticMethodIDNoThrow(global::java.text.Collator.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.Collator.staticClass, global::java.text.Collator._m8)) as java.util.Locale[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.text.CollationKey getCollationKey(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getDecomposition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator.staticClass, "getDecomposition", "()I", ref global::java.text.Collator._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator.staticClass, "getStrength", "()I", ref global::java.text.Collator._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setStrength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.Collator.staticClass, "setStrength", "(I)V", ref global::java.text.Collator._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setDecomposition(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.Collator.staticClass, "setDecomposition", "(I)V", ref global::java.text.Collator._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected Collator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Collator._m14.native == global::System.IntPtr.Zero)
				global::java.text.Collator._m14 = @__env.GetMethodIDNoThrow(global::java.text.Collator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Collator.staticClass, global::java.text.Collator._m14);
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.Collator))]
	internal sealed partial class Collator_ : java.text.Collator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Collator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator_.staticClass, "hashCode", "()I", ref global::java.text.Collator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int compare(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Collator_.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::java.text.Collator_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.text.CollationKey getCollationKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Collator_.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", ref global::java.text.Collator_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.CollationKey;
		}
		static Collator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Collator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Collator"));
		}
	}
}
