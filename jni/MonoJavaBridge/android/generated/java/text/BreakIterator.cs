namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.BreakIterator_))]
	public abstract partial class BreakIterator : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BreakIterator()
		{
			InitJNI();
		}
		protected BreakIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone25220;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.BreakIterator._clone25220)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._clone25220)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25221;
		public abstract int next();
		internal static global::MonoJavaBridge.MethodId _next25222;
		public abstract int next(int arg0);
		internal static global::MonoJavaBridge.MethodId _previous25223;
		public abstract int previous();
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25224;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getAvailableLocales25224)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _current25225;
		public abstract int current();
		internal static global::MonoJavaBridge.MethodId _setText25226;
		public virtual void setText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.BreakIterator._setText25226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._setText25226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25227;
		public abstract void setText(java.text.CharacterIterator arg0);
		internal static global::MonoJavaBridge.MethodId _last25228;
		public abstract int last();
		internal static global::MonoJavaBridge.MethodId _first25229;
		public abstract int first();
		internal static global::MonoJavaBridge.MethodId _getText25230;
		public abstract global::java.text.CharacterIterator getText();
		internal static global::MonoJavaBridge.MethodId _following25231;
		public abstract int following(int arg0);
		internal static global::MonoJavaBridge.MethodId _preceding25232;
		public virtual int preceding(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator._preceding25232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._preceding25232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBoundary25233;
		public virtual bool isBoundary(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.BreakIterator._isBoundary25233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.BreakIterator.staticClass, global::java.text.BreakIterator._isBoundary25233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWordInstance25234;
		public static global::java.text.BreakIterator getWordInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getWordInstance25234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getWordInstance25235;
		public static global::java.text.BreakIterator getWordInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getWordInstance25235)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getLineInstance25236;
		public static global::java.text.BreakIterator getLineInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getLineInstance25236)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getLineInstance25237;
		public static global::java.text.BreakIterator getLineInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getLineInstance25237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterInstance25238;
		public static global::java.text.BreakIterator getCharacterInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getCharacterInstance25238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterInstance25239;
		public static global::java.text.BreakIterator getCharacterInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getCharacterInstance25239)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getSentenceInstance25240;
		public static global::java.text.BreakIterator getSentenceInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getSentenceInstance25240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getSentenceInstance25241;
		public static global::java.text.BreakIterator getSentenceInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._getSentenceInstance25241)) as java.text.BreakIterator;
		}
		internal static global::MonoJavaBridge.MethodId _BreakIterator25242;
		protected BreakIterator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.BreakIterator.staticClass, global::java.text.BreakIterator._BreakIterator25242);
			Init(@__env, handle);
		}
		public static int DONE
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.BreakIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/BreakIterator"));
			global::java.text.BreakIterator._clone25220 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.BreakIterator._next25221 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "next", "()I");
			global::java.text.BreakIterator._next25222 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "next", "(I)I");
			global::java.text.BreakIterator._previous25223 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "previous", "()I");
			global::java.text.BreakIterator._getAvailableLocales25224 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.BreakIterator._current25225 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "current", "()I");
			global::java.text.BreakIterator._setText25226 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.BreakIterator._setText25227 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.BreakIterator._last25228 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "last", "()I");
			global::java.text.BreakIterator._first25229 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "first", "()I");
			global::java.text.BreakIterator._getText25230 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getText", "()Ljava/text/CharacterIterator;");
			global::java.text.BreakIterator._following25231 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "following", "(I)I");
			global::java.text.BreakIterator._preceding25232 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "preceding", "(I)I");
			global::java.text.BreakIterator._isBoundary25233 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "isBoundary", "(I)Z");
			global::java.text.BreakIterator._getWordInstance25234 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getWordInstance25235 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getWordInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getLineInstance25236 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getLineInstance25237 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getCharacterInstance25238 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getCharacterInstance25239 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getCharacterInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getSentenceInstance25240 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._getSentenceInstance25241 = @__env.GetStaticMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "getSentenceInstance", "()Ljava/text/BreakIterator;");
			global::java.text.BreakIterator._BreakIterator25242 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.BreakIterator))]
	internal sealed partial class BreakIterator_ : java.text.BreakIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BreakIterator_()
		{
			InitJNI();
		}
		internal BreakIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _next25244;
		public override int next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._next25244);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._next25244);
		}
		internal static global::MonoJavaBridge.MethodId _next25245;
		public override int next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._next25245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._next25245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previous25246;
		public override int previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._previous25246);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._previous25246);
		}
		internal static global::MonoJavaBridge.MethodId _current25247;
		public override int current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._current25247);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._current25247);
		}
		internal static global::MonoJavaBridge.MethodId _setText25248;
		public override void setText(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.BreakIterator_._setText25248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._setText25248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _last25249;
		public override int last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._last25249);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._last25249);
		}
		internal static global::MonoJavaBridge.MethodId _first25250;
		public override int first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._first25250);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._first25250);
		}
		internal static global::MonoJavaBridge.MethodId _getText25251;
		public override global::java.text.CharacterIterator getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.CharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.BreakIterator_._getText25251)) as java.text.CharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.CharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._getText25251)) as java.text.CharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _following25252;
		public override int following(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.BreakIterator_._following25252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.BreakIterator_.staticClass, global::java.text.BreakIterator_._following25252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.BreakIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/BreakIterator"));
			global::java.text.BreakIterator_._next25244 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "next", "()I");
			global::java.text.BreakIterator_._next25245 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "next", "(I)I");
			global::java.text.BreakIterator_._previous25246 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "previous", "()I");
			global::java.text.BreakIterator_._current25247 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "current", "()I");
			global::java.text.BreakIterator_._setText25248 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "setText", "(Ljava/text/CharacterIterator;)V");
			global::java.text.BreakIterator_._last25249 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "last", "()I");
			global::java.text.BreakIterator_._first25250 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "first", "()I");
			global::java.text.BreakIterator_._getText25251 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "getText", "()Ljava/text/CharacterIterator;");
			global::java.text.BreakIterator_._following25252 = @__env.GetMethodIDNoThrow(global::java.text.BreakIterator_.staticClass, "following", "(I)I");
		}
	}
}
