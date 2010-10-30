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
	internal sealed partial class CharacterIterator_ : java.lang.Object, CharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharacterIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone25254;
		global::java.lang.Object java.text.CharacterIterator.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.CharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.CharacterIterator_._clone25254) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25255;
		char java.text.CharacterIterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "next", "()C", ref global::java.text.CharacterIterator_._next25255);
		}
		internal static global::MonoJavaBridge.MethodId _previous25256;
		char java.text.CharacterIterator.previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "previous", "()C", ref global::java.text.CharacterIterator_._previous25256);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25257;
		int java.text.CharacterIterator.getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CharacterIterator_.staticClass, "getIndex", "()I", ref global::java.text.CharacterIterator_._getIndex25257);
		}
		internal static global::MonoJavaBridge.MethodId _current25258;
		char java.text.CharacterIterator.current()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "current", "()C", ref global::java.text.CharacterIterator_._current25258);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25259;
		char java.text.CharacterIterator.setIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "setIndex", "(I)C", ref global::java.text.CharacterIterator_._setIndex25259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25260;
		int java.text.CharacterIterator.getBeginIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CharacterIterator_.staticClass, "getBeginIndex", "()I", ref global::java.text.CharacterIterator_._getBeginIndex25260);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex25261;
		int java.text.CharacterIterator.getEndIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CharacterIterator_.staticClass, "getEndIndex", "()I", ref global::java.text.CharacterIterator_._getEndIndex25261);
		}
		internal static global::MonoJavaBridge.MethodId _last25262;
		char java.text.CharacterIterator.last()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "last", "()C", ref global::java.text.CharacterIterator_._last25262);
		}
		internal static global::MonoJavaBridge.MethodId _first25263;
		char java.text.CharacterIterator.first()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "first", "()C", ref global::java.text.CharacterIterator_._first25263);
		}
		static CharacterIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CharacterIterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
