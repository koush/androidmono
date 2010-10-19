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
		internal static global::MonoJavaBridge.MethodId _getAttributes19312;
		 global::java.util.Map java.text.AttributedCharacterIterator.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttributes19312)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttributes19312)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute19313;
		 global::java.lang.Object java.text.AttributedCharacterIterator.getAttribute(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAttribute19313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAttribute19313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart19314;
		 int java.text.AttributedCharacterIterator.getRunStart(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart19314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart19314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart19315;
		 int java.text.AttributedCharacterIterator.getRunStart(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart19315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart19315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunStart19316;
		 int java.text.AttributedCharacterIterator.getRunStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunStart19316);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunStart19316);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit19317;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit19317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit19317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit19318;
		 int java.text.AttributedCharacterIterator.getRunLimit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit19318);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit19318);
		}
		internal static global::MonoJavaBridge.MethodId _getRunLimit19319;
		 int java.text.AttributedCharacterIterator.getRunLimit(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getRunLimit19319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getRunLimit19319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllAttributeKeys19320;
		 global::java.util.Set java.text.AttributedCharacterIterator.getAllAttributeKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys19320)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getAllAttributeKeys19320)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _clone19321;
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._clone19321)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._clone19321)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next19322;
		 char java.text.CharacterIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._next19322);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._next19322);
		}
		internal static global::MonoJavaBridge.MethodId _previous19323;
		 char java.text.CharacterIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._previous19323);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._previous19323);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex19324;
		 int java.text.CharacterIterator.getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getIndex19324);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getIndex19324);
		}
		internal static global::MonoJavaBridge.MethodId _current19325;
		 char java.text.CharacterIterator.current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._current19325);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._current19325);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex19326;
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._setIndex19326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._setIndex19326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex19327;
		 int java.text.CharacterIterator.getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getBeginIndex19327);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getBeginIndex19327);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex19328;
		 int java.text.CharacterIterator.getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._getEndIndex19328);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._getEndIndex19328);
		}
		internal static global::MonoJavaBridge.MethodId _last19329;
		 char java.text.CharacterIterator.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._last19329);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._last19329);
		}
		internal static global::MonoJavaBridge.MethodId _first19330;
		 char java.text.CharacterIterator.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_._first19330);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.AttributedCharacterIterator_.staticClass, global::java.text.AttributedCharacterIterator_._first19330);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.AttributedCharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/AttributedCharacterIterator"));
			global::java.text.AttributedCharacterIterator_._getAttributes19312 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttributes", "()Ljava/util/Map;");
			global::java.text.AttributedCharacterIterator_._getAttribute19313 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._getRunStart19314 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart19315 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunStart19316 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunStart", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit19317 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I");
			global::java.text.AttributedCharacterIterator_._getRunLimit19318 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "()I");
			global::java.text.AttributedCharacterIterator_._getRunLimit19319 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getRunLimit", "(Ljava/util/Set;)I");
			global::java.text.AttributedCharacterIterator_._getAllAttributeKeys19320 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getAllAttributeKeys", "()Ljava/util/Set;");
			global::java.text.AttributedCharacterIterator_._clone19321 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.AttributedCharacterIterator_._next19322 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "next", "()C");
			global::java.text.AttributedCharacterIterator_._previous19323 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "previous", "()C");
			global::java.text.AttributedCharacterIterator_._getIndex19324 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.AttributedCharacterIterator_._current19325 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "current", "()C");
			global::java.text.AttributedCharacterIterator_._setIndex19326 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.AttributedCharacterIterator_._getBeginIndex19327 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.AttributedCharacterIterator_._getEndIndex19328 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.AttributedCharacterIterator_._last19329 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "last", "()C");
			global::java.text.AttributedCharacterIterator_._first19330 = @__env.GetMethodIDNoThrow(global::java.text.AttributedCharacterIterator_.staticClass, "first", "()C");
		}
	}
}
