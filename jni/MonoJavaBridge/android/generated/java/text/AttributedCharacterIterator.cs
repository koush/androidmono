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
		internal static global::MonoJavaBridge.MethodId _getAttributes25050;
		 global::java.util.Map java.text.AttributedCharacterIterator.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttributes25050)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttributes25050)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute25051;
		 global::java.lang.Object java.text.AttributedCharacterIterator.getAttribute(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttribute25051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttribute25051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart25052;
		 int java.text.AttributedCharacterIterator.getRunStart(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart25052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart25052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart25053;
		 int java.text.AttributedCharacterIterator.getRunStart(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart25053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart25053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart25054;
		 int java.text.AttributedCharacterIterator.getRunStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart25054);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart25054);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit25055;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit25055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit25055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit25056;
		 int java.text.AttributedCharacterIterator.getRunLimit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit25056);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit25056);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit25057;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit25057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit25057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllAttributeKeys25058;
		 global::java.util.Set java.text.AttributedCharacterIterator.getAllAttributeKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys25058)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys25058)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _clone25059;
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._clone25059)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._clone25059)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25060;
		 char java.text.CharacterIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._next25060);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._next25060);
		}
		internal static global::MonoJavaBridge.MethodId _previous25061;
		 char java.text.CharacterIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._previous25061);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._previous25061);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25062;
		 int java.text.CharacterIterator.getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getIndex25062);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getIndex25062);
		}
		internal static global::MonoJavaBridge.MethodId _current25063;
		 char java.text.CharacterIterator.current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._current25063);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._current25063);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25064;
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._setIndex25064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._setIndex25064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25065;
		 int java.text.CharacterIterator.getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getBeginIndex25065);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getBeginIndex25065);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex25066;
		 int java.text.CharacterIterator.getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getEndIndex25066);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getEndIndex25066);
		}
		internal static global::MonoJavaBridge.MethodId _last25067;
		 char java.text.CharacterIterator.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._last25067);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._last25067);
		}
		internal static global::MonoJavaBridge.MethodId _first25068;
		 char java.text.CharacterIterator.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._first25068);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._first25068);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator"));
			global::java.text.AttributedCharacterIterator_._getAttributes25050 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttributes", "()Ljava/util/Map;");
			global::java.text.AttributedCharacterIterator_._getAttribute25051 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._getRunStart25052 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart25053 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart25054 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit25055 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunLimit25056 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit25057 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getAllAttributeKeys25058 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAllAttributeKeys", "()Ljava/util/Set;");
			global::java.text.AttributedCharacterIterator_._clone25059 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._next25060 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "next", "()C");
			global::java.text.AttributedCharacterIterator_._previous25061 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "previous", "()C");
			global::java.text.AttributedCharacterIterator_._getIndex25062 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.AttributedCharacterIterator_._current25063 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "current", "()C");
			global::java.text.AttributedCharacterIterator_._setIndex25064 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.AttributedCharacterIterator_._getBeginIndex25065 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.AttributedCharacterIterator_._getEndIndex25066 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.AttributedCharacterIterator_._last25067 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "last", "()C");
			global::java.text.AttributedCharacterIterator_._first25068 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "first", "()C");
		}
	}
}
