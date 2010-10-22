namespace java.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.text.CharacterIterator_))]
	public partial interface CharacterIterator : java.lang.Cloneable
	{
		global::java.lang.Object clone();
		char next();
		char previous();
		int getIndex();
		char current();
		char setIndex(int arg0);
		int getBeginIndex();
		int getEndIndex();
		char last();
		char first();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.CharacterIterator))]
	public sealed partial class CharacterIterator_ : java.lang.Object, CharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharacterIterator_()
		{
			InitJNI();
		}
		internal CharacterIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone25135;
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_._clone25135)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._clone25135)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25136;
		 char java.text.CharacterIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._next25136);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._next25136);
		}
		internal static global::MonoJavaBridge.MethodId _previous25137;
		 char java.text.CharacterIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._previous25137);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._previous25137);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25138;
		 int java.text.CharacterIterator.getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getIndex25138);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getIndex25138);
		}
		internal static global::MonoJavaBridge.MethodId _current25139;
		 char java.text.CharacterIterator.current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._current25139);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._current25139);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25140;
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._setIndex25140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._setIndex25140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25141;
		 int java.text.CharacterIterator.getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getBeginIndex25141);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getBeginIndex25141);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex25142;
		 int java.text.CharacterIterator.getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getEndIndex25142);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getEndIndex25142);
		}
		internal static global::MonoJavaBridge.MethodId _last25143;
		 char java.text.CharacterIterator.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._last25143);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._last25143);
		}
		internal static global::MonoJavaBridge.MethodId _first25144;
		 char java.text.CharacterIterator.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._first25144);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._first25144);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CharacterIterator"));
			global::java.text.CharacterIterator_._clone25135 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.CharacterIterator_._next25136 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "next", "()C");
			global::java.text.CharacterIterator_._previous25137 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "previous", "()C");
			global::java.text.CharacterIterator_._getIndex25138 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.CharacterIterator_._current25139 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "current", "()C");
			global::java.text.CharacterIterator_._setIndex25140 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.CharacterIterator_._getBeginIndex25141 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.CharacterIterator_._getEndIndex25142 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.CharacterIterator_._last25143 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "last", "()C");
			global::java.text.CharacterIterator_._first25144 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "first", "()C");
		}
	}
}
