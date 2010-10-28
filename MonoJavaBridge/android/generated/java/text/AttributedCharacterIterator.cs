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
		internal static global::MonoJavaBridge.MethodId _getAttributes25169;
		global::java.util.Map java.text.AttributedCharacterIterator.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttributes25169)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttributes25169)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute25170;
		global::java.lang.Object java.text.AttributedCharacterIterator.getAttribute(java.text.AttributedCharacterIterator_Attribute arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttribute25170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttribute25170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart25171;
		int java.text.AttributedCharacterIterator.getRunStart(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart25171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart25171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart25172;
		int java.text.AttributedCharacterIterator.getRunStart(java.text.AttributedCharacterIterator_Attribute arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart25172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart25172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart25173;
		int java.text.AttributedCharacterIterator.getRunStart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart25173);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart25173);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit25174;
		int java.text.AttributedCharacterIterator.getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit25174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit25174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit25175;
		int java.text.AttributedCharacterIterator.getRunLimit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit25175);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit25175);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit25176;
		int java.text.AttributedCharacterIterator.getRunLimit(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit25176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit25176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllAttributeKeys25177;
		global::java.util.Set java.text.AttributedCharacterIterator.getAllAttributeKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys25177)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys25177)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _clone25178;
		global::java.lang.Object java.text.CharacterIterator.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._clone25178)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._clone25178)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25179;
		char java.text.CharacterIterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._next25179);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._next25179);
		}
		internal static global::MonoJavaBridge.MethodId _previous25180;
		char java.text.CharacterIterator.previous()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._previous25180);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._previous25180);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25181;
		int java.text.CharacterIterator.getIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getIndex25181);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getIndex25181);
		}
		internal static global::MonoJavaBridge.MethodId _current25182;
		char java.text.CharacterIterator.current()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._current25182);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._current25182);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25183;
		char java.text.CharacterIterator.setIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._setIndex25183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._setIndex25183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25184;
		int java.text.CharacterIterator.getBeginIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getBeginIndex25184);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getBeginIndex25184);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex25185;
		int java.text.CharacterIterator.getEndIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getEndIndex25185);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getEndIndex25185);
		}
		internal static global::MonoJavaBridge.MethodId _last25186;
		char java.text.CharacterIterator.last()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._last25186);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._last25186);
		}
		internal static global::MonoJavaBridge.MethodId _first25187;
		char java.text.CharacterIterator.first()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._first25187);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._first25187);
		}
		static AttributedCharacterIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator"));
			global::java.text.AttributedCharacterIterator_._getAttributes25169 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttributes", "()Ljava/util/Map;");
			global::java.text.AttributedCharacterIterator_._getAttribute25170 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._getRunStart25171 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart25172 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart25173 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit25174 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunLimit25175 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit25176 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getAllAttributeKeys25177 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAllAttributeKeys", "()Ljava/util/Set;");
			global::java.text.AttributedCharacterIterator_._clone25178 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._next25179 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "next", "()C");
			global::java.text.AttributedCharacterIterator_._previous25180 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "previous", "()C");
			global::java.text.AttributedCharacterIterator_._getIndex25181 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.AttributedCharacterIterator_._current25182 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "current", "()C");
			global::java.text.AttributedCharacterIterator_._setIndex25183 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.AttributedCharacterIterator_._getBeginIndex25184 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.AttributedCharacterIterator_._getEndIndex25185 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.AttributedCharacterIterator_._last25186 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "last", "()C");
			global::java.text.AttributedCharacterIterator_._first25187 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "first", "()C");
		}
		internal static void InitJNI()
		{
		}
	}
}
