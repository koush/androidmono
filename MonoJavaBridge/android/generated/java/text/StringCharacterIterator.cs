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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._equals25648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25649;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._hashCode25649);
		}
		internal static global::MonoJavaBridge.MethodId _clone25650;
		public global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._clone25650)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25651;
		public char next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._next25651);
		}
		internal static global::MonoJavaBridge.MethodId _previous25652;
		public char previous()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._previous25652);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getIndex25653);
		}
		internal static global::MonoJavaBridge.MethodId _current25654;
		public char current()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._current25654);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25655;
		public char setIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._setIndex25655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getBeginIndex25656);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._getEndIndex25657);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._setText25658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _last25659;
		public char last()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._last25659);
		}
		internal static global::MonoJavaBridge.MethodId _first25660;
		public char first()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._first25660);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25661;
		public StringCharacterIterator(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25662;
		public StringCharacterIterator(java.lang.String arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringCharacterIterator25663;
		public StringCharacterIterator(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._StringCharacterIterator25663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringCharacterIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.StringCharacterIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/StringCharacterIterator"));
			global::java.text.StringCharacterIterator._equals25648 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.StringCharacterIterator._hashCode25649 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "hashCode", "()I");
			global::java.text.StringCharacterIterator._clone25650 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.StringCharacterIterator._next25651 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "next", "()C");
			global::java.text.StringCharacterIterator._previous25652 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "previous", "()C");
			global::java.text.StringCharacterIterator._getIndex25653 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getIndex", "()I");
			global::java.text.StringCharacterIterator._current25654 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "current", "()C");
			global::java.text.StringCharacterIterator._setIndex25655 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "setIndex", "(I)C");
			global::java.text.StringCharacterIterator._getBeginIndex25656 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getBeginIndex", "()I");
			global::java.text.StringCharacterIterator._getEndIndex25657 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "getEndIndex", "()I");
			global::java.text.StringCharacterIterator._setText25658 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "setText", "(Ljava/lang/String;)V");
			global::java.text.StringCharacterIterator._last25659 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "last", "()C");
			global::java.text.StringCharacterIterator._first25660 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "first", "()C");
			global::java.text.StringCharacterIterator._StringCharacterIterator25661 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.text.StringCharacterIterator._StringCharacterIterator25662 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;III)V");
			global::java.text.StringCharacterIterator._StringCharacterIterator25663 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
