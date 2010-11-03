namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RuleBasedCollator : java.text.Collator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RuleBasedCollator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.RuleBasedCollator.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.RuleBasedCollator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.RuleBasedCollator.staticClass, "hashCode", "()I", ref global::java.text.RuleBasedCollator._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.RuleBasedCollator.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.RuleBasedCollator._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int compare(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.RuleBasedCollator.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::java.text.RuleBasedCollator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.text.CollationKey getCollationKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.RuleBasedCollator.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", ref global::java.text.RuleBasedCollator._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.CollationKey;
		}
		public new global::java.lang.String Rules
		{
			get
			{
				return getRules();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getRules()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.RuleBasedCollator.staticClass, "getRules", "()Ljava/lang/String;", ref global::java.text.RuleBasedCollator._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.text.CharacterIterator arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.text.CollationElementIterator>(this, global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;", ref global::java.text.RuleBasedCollator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.CollationElementIterator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.text.CollationElementIterator>(this, global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/lang/String;)Ljava/text/CollationElementIterator;", ref global::java.text.RuleBasedCollator._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.CollationElementIterator;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public RuleBasedCollator(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._m8.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._m8 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RuleBasedCollator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.RuleBasedCollator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/RuleBasedCollator"));
		}
	}
}
