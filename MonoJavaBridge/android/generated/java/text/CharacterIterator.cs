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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.text.CharacterIterator.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.CharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.CharacterIterator_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		char java.text.CharacterIterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "next", "()C", ref global::java.text.CharacterIterator_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		char java.text.CharacterIterator.previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "previous", "()C", ref global::java.text.CharacterIterator_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int java.text.CharacterIterator.getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CharacterIterator_.staticClass, "getIndex", "()I", ref global::java.text.CharacterIterator_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		char java.text.CharacterIterator.current()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "current", "()C", ref global::java.text.CharacterIterator_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		char java.text.CharacterIterator.setIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "setIndex", "(I)C", ref global::java.text.CharacterIterator_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int java.text.CharacterIterator.getBeginIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CharacterIterator_.staticClass, "getBeginIndex", "()I", ref global::java.text.CharacterIterator_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		int java.text.CharacterIterator.getEndIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CharacterIterator_.staticClass, "getEndIndex", "()I", ref global::java.text.CharacterIterator_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		char java.text.CharacterIterator.last()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "last", "()C", ref global::java.text.CharacterIterator_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		char java.text.CharacterIterator.first()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.CharacterIterator_.staticClass, "first", "()C", ref global::java.text.CharacterIterator_._m9);
		}
		static CharacterIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CharacterIterator"));
		}
	}
}
