namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
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

	public partial class AttributedCharacterIterator_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __AttributedCharacterIterator.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __AttributedCharacterIterator : java.lang.Object, AttributedCharacterIterator
	{ 
		internal static global::java.lang.Class staticClass; 
		static __AttributedCharacterIterator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.__AttributedCharacterIterator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.text.__AttributedCharacterIterator(@__env); 
			} 
		} 
		internal __AttributedCharacterIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributes12537; 
		 global::java.util.Map java.text.AttributedCharacterIterator.getAttributes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._getAttributes12537)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getAttributes12537)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttribute12538; 
		 global::java.lang.Object java.text.AttributedCharacterIterator.getAttribute(java.text.AttributedCharacterIterator_Attribute arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._getAttribute12538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getAttribute12538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunStart12539; 
		 int java.text.AttributedCharacterIterator.getRunStart(java.util.Set arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunStart12539, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunStart12539, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunStart12540; 
		 int java.text.AttributedCharacterIterator.getRunStart(java.text.AttributedCharacterIterator_Attribute arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunStart12540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunStart12540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunStart12541; 
		 int java.text.AttributedCharacterIterator.getRunStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunStart12541); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunStart12541); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunLimit12542; 
		 int java.text.AttributedCharacterIterator.getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunLimit12542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunLimit12542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunLimit12543; 
		 int java.text.AttributedCharacterIterator.getRunLimit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunLimit12543); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunLimit12543); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunLimit12544; 
		 int java.text.AttributedCharacterIterator.getRunLimit(java.util.Set arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getRunLimit12544, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getRunLimit12544, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllAttributeKeys12545; 
		 global::java.util.Set java.text.AttributedCharacterIterator.getAllAttributeKeys() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._getAllAttributeKeys12545)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getAllAttributeKeys12545)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12546; 
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator._clone12546)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._clone12546)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next12547; 
		 char java.text.CharacterIterator.next() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._next12547); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._next12547); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _previous12548; 
		 char java.text.CharacterIterator.previous() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._previous12548); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._previous12548); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndex12549; 
		 int java.text.CharacterIterator.getIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getIndex12549); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getIndex12549); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _current12550; 
		 char java.text.CharacterIterator.current() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._current12550); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._current12550); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndex12551; 
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._setIndex12551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._setIndex12551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBeginIndex12552; 
		 int java.text.CharacterIterator.getBeginIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getBeginIndex12552); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getBeginIndex12552); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEndIndex12553; 
		 int java.text.CharacterIterator.getEndIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__AttributedCharacterIterator._getEndIndex12553); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._getEndIndex12553); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _last12554; 
		 char java.text.CharacterIterator.last() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._last12554); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._last12554); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _first12555; 
		 char java.text.CharacterIterator.first() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__AttributedCharacterIterator._first12555); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__AttributedCharacterIterator.staticClass, global::java.text.__AttributedCharacterIterator._first12555); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.text.__AttributedCharacterIterator.staticClass = @__class; 
			global::java.text.__AttributedCharacterIterator._getAttributes12537 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getAttributes", "()Ljava/util/Map;"); 
			global::java.text.__AttributedCharacterIterator._getAttribute12538 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;"); 
			global::java.text.__AttributedCharacterIterator._getRunStart12539 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunStart", "(Ljava/util/Set;)I"); 
			global::java.text.__AttributedCharacterIterator._getRunStart12540 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I"); 
			global::java.text.__AttributedCharacterIterator._getRunStart12541 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunStart", "()I"); 
			global::java.text.__AttributedCharacterIterator._getRunLimit12542 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I"); 
			global::java.text.__AttributedCharacterIterator._getRunLimit12543 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunLimit", "()I"); 
			global::java.text.__AttributedCharacterIterator._getRunLimit12544 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getRunLimit", "(Ljava/util/Set;)I"); 
			global::java.text.__AttributedCharacterIterator._getAllAttributeKeys12545 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.AttributedCharacterIterator.getAllAttributeKeys", "()Ljava/util/Set;"); 
			global::java.text.__AttributedCharacterIterator._clone12546 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.clone", "()Ljava/lang/Object;"); 
			global::java.text.__AttributedCharacterIterator._next12547 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.next", "()C"); 
			global::java.text.__AttributedCharacterIterator._previous12548 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.previous", "()C"); 
			global::java.text.__AttributedCharacterIterator._getIndex12549 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.getIndex", "()I"); 
			global::java.text.__AttributedCharacterIterator._current12550 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.current", "()C"); 
			global::java.text.__AttributedCharacterIterator._setIndex12551 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.setIndex", "(I)C"); 
			global::java.text.__AttributedCharacterIterator._getBeginIndex12552 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.getBeginIndex", "()I"); 
			global::java.text.__AttributedCharacterIterator._getEndIndex12553 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.getEndIndex", "()I"); 
			global::java.text.__AttributedCharacterIterator._last12554 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.last", "()C"); 
			global::java.text.__AttributedCharacterIterator._first12555 = @__env.GetMethodID(global::java.text.__AttributedCharacterIterator.staticClass, "java.text.CharacterIterator.first", "()C"); 
		} 
	} 
} 
