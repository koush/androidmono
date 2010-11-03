namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.BreakIterator_))]
	public abstract partial class BreakIterator : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BreakIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.BreakIterator.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.BreakIterator._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract int next();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int next(int arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int previous();
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m4.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m4 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m4)) as java.util.Locale[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int current();
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.BreakIterator.staticClass, "setText", "(Ljava/lang/String;)V", ref global::java.text.BreakIterator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract void setText(java.text.CharacterIterator arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract int last();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract int first();
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract global::java.text.CharacterIterator getText();
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract int following(int arg0);
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int preceding(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator.staticClass, "preceding", "(I)I", ref global::java.text.BreakIterator._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isBoundary(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.BreakIterator.staticClass, "isBoundary", "(I)Z", ref global::java.text.BreakIterator._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.text.BreakIterator getWordInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m14.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m14 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.text.BreakIterator getWordInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m15.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m15 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "()Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m15)) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.text.BreakIterator getLineInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m16.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m16 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "()Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m16)) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.text.BreakIterator getLineInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m17.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m17 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.text.BreakIterator getCharacterInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m18.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m18 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.text.BreakIterator getCharacterInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m19.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m19 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "()Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m19)) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.text.BreakIterator getSentenceInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m20.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m20 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static global::java.text.BreakIterator getSentenceInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m21.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m21 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "()Ljava/text/BreakIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m21)) as java.text.BreakIterator;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected BreakIterator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.BreakIterator._m22.native == global::System.IntPtr.Zero)
				global::java.text.BreakIterator._m22 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._m22);
			Init(@__env, handle);
		}
		public static int DONE
		{
			get
			{
				return -1;
			}
		}
		static BreakIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.BreakIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/BreakIterator"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.BreakIterator))]
	internal sealed partial class BreakIterator_ : java.text.BreakIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BreakIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int next()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator_.staticClass, "next", "()I", ref global::java.text.BreakIterator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int next(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator_.staticClass, "next", "(I)I", ref global::java.text.BreakIterator_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator_.staticClass, "previous", "()I", ref global::java.text.BreakIterator_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int current()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator_.staticClass, "current", "()I", ref global::java.text.BreakIterator_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setText(java.text.CharacterIterator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.BreakIterator_.staticClass, "setText", "(Ljava/text/CharacterIterator;)V", ref global::java.text.BreakIterator_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int last()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator_.staticClass, "last", "()I", ref global::java.text.BreakIterator_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int first()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator_.staticClass, "first", "()I", ref global::java.text.BreakIterator_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.text.CharacterIterator getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.CharacterIterator>(this, global::java.text.BreakIterator_.staticClass, "getText", "()Ljava/text/CharacterIterator;", ref global::java.text.BreakIterator_._m7) as java.text.CharacterIterator;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int following(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.BreakIterator_.staticClass, "following", "(I)I", ref global::java.text.BreakIterator_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static BreakIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.BreakIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/BreakIterator"));
		}
	}
}
