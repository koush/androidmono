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
		internal static global::MonoJavaBridge.MethodId _equals25502;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.RuleBasedCollator._equals25502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._equals25502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25503;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator._hashCode25503);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._hashCode25503);
		}
		internal static global::MonoJavaBridge.MethodId _clone25504;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._clone25504)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._clone25504)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compare25505;
		public override int compare(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator._compare25505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._compare25505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCollationKey25506;
		public override global::java.text.CollationKey getCollationKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getCollationKey25506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationKey25506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationKey;
		}
		public new global::java.lang.String Rules
		{
			get
			{
				return getRules();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRules25507;
		public virtual global::java.lang.String getRules() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getRules25507)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getRules25507)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCollationElementIterator25508;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.text.CharacterIterator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.text.CollationElementIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getCollationElementIterator25508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.text.CollationElementIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationElementIterator25508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
		}
		internal static global::MonoJavaBridge.MethodId _getCollationElementIterator25509;
		public virtual global::java.text.CollationElementIterator getCollationElementIterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.text.CollationElementIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator._getCollationElementIterator25509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.text.CollationElementIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._getCollationElementIterator25509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.CollationElementIterator;
		}
		internal static global::MonoJavaBridge.MethodId _RuleBasedCollator25510;
		public RuleBasedCollator(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.RuleBasedCollator.staticClass, global::java.text.RuleBasedCollator._RuleBasedCollator25510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.RuleBasedCollator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/RuleBasedCollator"));
			global::java.text.RuleBasedCollator._equals25502 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.RuleBasedCollator._hashCode25503 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "hashCode", "()I");
			global::java.text.RuleBasedCollator._clone25504 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.RuleBasedCollator._compare25505 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::java.text.RuleBasedCollator._getCollationKey25506 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;");
			global::java.text.RuleBasedCollator._getRules25507 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getRules", "()Ljava/lang/String;");
			global::java.text.RuleBasedCollator._getCollationElementIterator25508 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;");
			global::java.text.RuleBasedCollator._getCollationElementIterator25509 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "getCollationElementIterator", "(Ljava/lang/String;)Ljava/text/CollationElementIterator;");
			global::java.text.RuleBasedCollator._RuleBasedCollator25510 = @__env.GetMethodIDNoThrow(global::java.text.RuleBasedCollator.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
