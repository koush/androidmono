namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RuleBasedCollator : java.text.Collator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RuleBasedCollator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25621;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._equals25621.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._equals25621 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._equals25621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25622;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._hashCode25622.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._hashCode25622 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._hashCode25622);
		}
		internal static global::MonoJavaBridge.MethodId _clone25623;
		public override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._clone25623.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._clone25623 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._clone25623) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compare25624;
		public override int compare(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._compare25624.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._compare25624 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._compare25624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey25625;
		public override global::java.text.CollationKey getCollationKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._getCollationKey25625.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._getCollationKey25625 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationKey25625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.CollationKey;
		}
		public new global::java.lang.String Rules
		{
			get
			{
				return getRules();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRules25626;
		public virtual global::java.lang.String getRules()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._getRules25626.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._getRules25626 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getRules", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getRules25626) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCollationElementIterator25627;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.text.CharacterIterator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._getCollationElementIterator25627.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._getCollationElementIterator25627 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.text.CollationElementIterator>(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationElementIterator25627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.CollationElementIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCollationElementIterator25628;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._getCollationElementIterator25628.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._getCollationElementIterator25628 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/lang/String;)Ljava/text/CollationElementIterator;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.text.CollationElementIterator>(this, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationElementIterator25628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.CollationElementIterator;
		}
		internal static global::MonoJavaBridge.MethodId _RuleBasedCollator25629;
		public RuleBasedCollator(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.RuleBasedCollator._RuleBasedCollator25629.native == global::System.IntPtr.Zero)
				global::java.text.RuleBasedCollator._RuleBasedCollator25629 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._RuleBasedCollator25629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RuleBasedCollator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.RuleBasedCollator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/RuleBasedCollator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
