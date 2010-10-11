namespace java.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.text.AttributedCharacterIterator_))]
	public interface AttributedCharacterIterator : CharacterIterator
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
	public sealed partial class AttributedCharacterIterator_ : java.lang.Object, AttributedCharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributedCharacterIterator_()
		{
			InitJNI();
		}
		internal AttributedCharacterIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes15038;
		 global::java.util.Map java.text.AttributedCharacterIterator.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttributes15038)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttributes15038)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute15039;
		 global::java.lang.Object java.text.AttributedCharacterIterator.getAttribute(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttribute15039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttribute15039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart15040;
		 int java.text.AttributedCharacterIterator.getRunStart(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart15040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart15040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart15041;
		 int java.text.AttributedCharacterIterator.getRunStart(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart15041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart15041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart15042;
		 int java.text.AttributedCharacterIterator.getRunStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart15042);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart15042);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit15043;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit15043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit15043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit15044;
		 int java.text.AttributedCharacterIterator.getRunLimit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit15044);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit15044);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit15045;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit15045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit15045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllAttributeKeys15046;
		 global::java.util.Set java.text.AttributedCharacterIterator.getAllAttributeKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys15046)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys15046)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _clone15047;
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._clone15047)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._clone15047)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next15048;
		 char java.text.CharacterIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._next15048);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._next15048);
		}
		internal static global::MonoJavaBridge.MethodId _previous15049;
		 char java.text.CharacterIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._previous15049);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._previous15049);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex15050;
		 int java.text.CharacterIterator.getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getIndex15050);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getIndex15050);
		}
		internal static global::MonoJavaBridge.MethodId _current15051;
		 char java.text.CharacterIterator.current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._current15051);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._current15051);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex15052;
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._setIndex15052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._setIndex15052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex15053;
		 int java.text.CharacterIterator.getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getBeginIndex15053);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getBeginIndex15053);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex15054;
		 int java.text.CharacterIterator.getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getEndIndex15054);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getEndIndex15054);
		}
		internal static global::MonoJavaBridge.MethodId _last15055;
		 char java.text.CharacterIterator.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._last15055);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._last15055);
		}
		internal static global::MonoJavaBridge.MethodId _first15056;
		 char java.text.CharacterIterator.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._first15056);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._first15056);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator"));
			global::java.text.AttributedCharacterIterator_._getAttributes15038 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttributes", "()Ljava/util/Map;");
			global::java.text.AttributedCharacterIterator_._getAttribute15039 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._getRunStart15040 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart15041 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart15042 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit15043 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunLimit15044 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit15045 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getAllAttributeKeys15046 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAllAttributeKeys", "()Ljava/util/Set;");
			global::java.text.AttributedCharacterIterator_._clone15047 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._next15048 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "next", "()C");
			global::java.text.AttributedCharacterIterator_._previous15049 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "previous", "()C");
			global::java.text.AttributedCharacterIterator_._getIndex15050 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.AttributedCharacterIterator_._current15051 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "current", "()C");
			global::java.text.AttributedCharacterIterator_._setIndex15052 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.AttributedCharacterIterator_._getBeginIndex15053 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.AttributedCharacterIterator_._getEndIndex15054 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.AttributedCharacterIterator_._last15055 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "last", "()C");
			global::java.text.AttributedCharacterIterator_._first15056 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "first", "()C");
		}
	}
}
