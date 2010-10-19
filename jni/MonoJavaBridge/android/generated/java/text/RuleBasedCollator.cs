namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RuleBasedCollator : java.text.Collator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RuleBasedCollator()
		{
			InitJNI();
		}
		protected RuleBasedCollator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals19726;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.RuleBasedCollator._equals19726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._equals19726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19727;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator._hashCode19727);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._hashCode19727);
		}
		internal static global::MonoJavaBridge.MethodId _clone19728;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._clone19728)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._clone19728)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compare19729;
		public override int compare(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator._compare19729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._compare19729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey19730;
		public override global::java.text.CollationKey getCollationKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getCollationKey19730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationKey19730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationKey;
		}
		public new global::java.lang.String Rules
		{
			get
			{
				return getRules();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRules19731;
		public virtual global::java.lang.String getRules() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getRules19731)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getRules19731)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCollationElementIterator19732;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getCollationElementIterator19732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationElementIterator19732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCollationElementIterator19733;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getCollationElementIterator19733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationElementIterator19733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
		}
		internal static global::MonoJavaBridge.MethodId _RuleBasedCollator19734;
		public RuleBasedCollator(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._RuleBasedCollator19734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.RuleBasedCollator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/RuleBasedCollator"));
			global::java.text.RuleBasedCollator._equals19726 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.RuleBasedCollator._hashCode19727 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "hashCode", "()I");
			global::java.text.RuleBasedCollator._clone19728 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.RuleBasedCollator._compare19729 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::java.text.RuleBasedCollator._getCollationKey19730 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;");
			global::java.text.RuleBasedCollator._getRules19731 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getRules", "()Ljava/lang/String;");
			global::java.text.RuleBasedCollator._getCollationElementIterator19732 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;");
			global::java.text.RuleBasedCollator._getCollationElementIterator19733 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/lang/String;)Ljava/text/CollationElementIterator;");
			global::java.text.RuleBasedCollator._RuleBasedCollator19734 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
