namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringCharacterIterator : java.lang.Object, CharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StringCharacterIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25648;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.StringCharacterIterator.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.StringCharacterIterator._equals25648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25649;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "hashCode", "()I", ref global::java.text.StringCharacterIterator._hashCode25649);
		}
		internal static global::MonoJavaBridge.MethodId _clone25650;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.StringCharacterIterator.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.StringCharacterIterator._clone25650) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25651;
		public char next()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "next", "()C", ref global::java.text.StringCharacterIterator._next25651);
		}
		internal static global::MonoJavaBridge.MethodId _previous25652;
		public char previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "previous", "()C", ref global::java.text.StringCharacterIterator._previous25652);
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
			set
			{
				setIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25653;
		public int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "getIndex", "()I", ref global::java.text.StringCharacterIterator._getIndex25653);
		}
		internal static global::MonoJavaBridge.MethodId _current25654;
		public char current()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "current", "()C", ref global::java.text.StringCharacterIterator._current25654);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25655;
		public char setIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "setIndex", "(I)C", ref global::java.text.StringCharacterIterator._setIndex25655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BeginIndex
		{
			get
			{
				return getBeginIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25656;
		public int getBeginIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "getBeginIndex", "()I", ref global::java.text.StringCharacterIterator._getBeginIndex25656);
		}
		public new int EndIndex
		{
			get
			{
				return getEndIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex25657;
		public int getEndIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "getEndIndex", "()I", ref global::java.text.StringCharacterIterator._getEndIndex25657);
		}
		public new global::java.lang.String Text
		{
			set
			{
				setText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setText25658;
		public void setText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.StringCharacterIterator.staticClass, "setText", "(Ljava/lang/String;)V", ref global::java.text.StringCharacterIterator._setText25658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _last25659;
		public char last()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "last", "()C", ref global::java.text.StringCharacterIterator._last25659);
		}
		internal static global::MonoJavaBridge.MethodId _first25660;
		public char first()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "first", "()C", ref global::java.text.StringCharacterIterator._first25660);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25661;
		public StringCharacterIterator(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.StringCharacterIterator._StringCharacterIterator25661.native == global::System.IntPtr.Zero)
				global::java.text.StringCharacterIterator._StringCharacterIterator25661 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25662;
		public StringCharacterIterator(java.lang.String arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.StringCharacterIterator._StringCharacterIterator25662.native == global::System.IntPtr.Zero)
				global::java.text.StringCharacterIterator._StringCharacterIterator25662 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25663;
		public StringCharacterIterator(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.StringCharacterIterator._StringCharacterIterator25663.native == global::System.IntPtr.Zero)
				global::java.text.StringCharacterIterator._StringCharacterIterator25663 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringCharacterIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.StringCharacterIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/StringCharacterIterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
