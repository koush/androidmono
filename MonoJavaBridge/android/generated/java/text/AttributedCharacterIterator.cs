namespace java.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.text.AttributedCharacterIterator_))]
	public partial interface AttributedCharacterIterator : CharacterIterator
	{
		global::java.util.Map getAttributes();
		global::java.lang.Object getAttribute(java.text.AttributedCharacterIterator_Attribute arg0);
		int getRunStart(java.util.Set arg0);
		int getRunStart(java.text.AttributedCharacterIterator_Attribute arg0);
		int getRunStart();
		int getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0);
		int getRunLimit();
		int getRunLimit(java.util.Set arg0);
		global::java.util.Set getAllAttributeKeys();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.AttributedCharacterIterator))]
	internal sealed partial class AttributedCharacterIterator_ : java.lang.Object, AttributedCharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AttributedCharacterIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.Map java.text.AttributedCharacterIterator.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.text.AttributedCharacterIterator_.staticClass, "getAttributes", "()Ljava/util/Map;", ref global::java.text.AttributedCharacterIterator_._m0) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.text.AttributedCharacterIterator.getAttribute(java.text.AttributedCharacterIterator_Attribute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;", ref global::java.text.AttributedCharacterIterator_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.text.AttributedCharacterIterator.getRunStart(java.util.Set arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/util/Set;)I", ref global::java.text.AttributedCharacterIterator_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int java.text.AttributedCharacterIterator.getRunStart(java.text.AttributedCharacterIterator_Attribute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", ref global::java.text.AttributedCharacterIterator_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.text.AttributedCharacterIterator.getRunStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "()I", ref global::java.text.AttributedCharacterIterator_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.text.AttributedCharacterIterator.getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", ref global::java.text.AttributedCharacterIterator_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int java.text.AttributedCharacterIterator.getRunLimit()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "()I", ref global::java.text.AttributedCharacterIterator_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		int java.text.AttributedCharacterIterator.getRunLimit(java.util.Set arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/util/Set;)I", ref global::java.text.AttributedCharacterIterator_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.util.Set java.text.AttributedCharacterIterator.getAllAttributeKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.text.AttributedCharacterIterator_.staticClass, "getAllAttributeKeys", "()Ljava/util/Set;", ref global::java.text.AttributedCharacterIterator_._m8) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.Object java.text.CharacterIterator.clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.AttributedCharacterIterator_._m9) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		char java.text.CharacterIterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "next", "()C", ref global::java.text.AttributedCharacterIterator_._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		char java.text.CharacterIterator.previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "previous", "()C", ref global::java.text.AttributedCharacterIterator_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int java.text.CharacterIterator.getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getIndex", "()I", ref global::java.text.AttributedCharacterIterator_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		char java.text.CharacterIterator.current()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "current", "()C", ref global::java.text.AttributedCharacterIterator_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		char java.text.CharacterIterator.setIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "setIndex", "(I)C", ref global::java.text.AttributedCharacterIterator_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		int java.text.CharacterIterator.getBeginIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getBeginIndex", "()I", ref global::java.text.AttributedCharacterIterator_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		int java.text.CharacterIterator.getEndIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "getEndIndex", "()I", ref global::java.text.AttributedCharacterIterator_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		char java.text.CharacterIterator.last()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "last", "()C", ref global::java.text.AttributedCharacterIterator_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		char java.text.CharacterIterator.first()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.AttributedCharacterIterator_.staticClass, "first", "()C", ref global::java.text.AttributedCharacterIterator_._m18);
		}
		static AttributedCharacterIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator"));
		}
	}
}
