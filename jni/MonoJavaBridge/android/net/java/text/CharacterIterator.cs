namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface CharacterIterator : java.lang.Cloneable
	{ 
		global::java.lang.Object clone(); 
		char next(); 
		char previous(); 
		int getIndex(); 
		char current(); 
		char setIndex(int arg0); 
		int getBeginIndex(); 
		int getEndIndex(); 
		char last(); 
		char first(); 
	} 

	public partial class CharacterIterator_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __CharacterIterator.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __CharacterIterator : java.lang.Object, CharacterIterator
	{ 
		internal static global::java.lang.Class staticClass; 
		static __CharacterIterator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.__CharacterIterator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.text.__CharacterIterator(@__env); 
			} 
		} 
		internal __CharacterIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12556; 
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.__CharacterIterator._clone12556)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._clone12556)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next12557; 
		 char java.text.CharacterIterator.next() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__CharacterIterator._next12557); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._next12557); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _previous12558; 
		 char java.text.CharacterIterator.previous() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__CharacterIterator._previous12558); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._previous12558); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndex12559; 
		 int java.text.CharacterIterator.getIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__CharacterIterator._getIndex12559); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._getIndex12559); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _current12560; 
		 char java.text.CharacterIterator.current() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__CharacterIterator._current12560); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._current12560); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndex12561; 
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__CharacterIterator._setIndex12561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._setIndex12561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBeginIndex12562; 
		 int java.text.CharacterIterator.getBeginIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__CharacterIterator._getBeginIndex12562); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._getBeginIndex12562); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEndIndex12563; 
		 int java.text.CharacterIterator.getEndIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.text.__CharacterIterator._getEndIndex12563); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._getEndIndex12563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _last12564; 
		 char java.text.CharacterIterator.last() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__CharacterIterator._last12564); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._last12564); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _first12565; 
		 char java.text.CharacterIterator.first() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallCharMethod(this, global::java.text.__CharacterIterator._first12565); 
			else 
				return @__env.CallNonVirtualCharMethod(this, global::java.text.__CharacterIterator.staticClass, global::java.text.__CharacterIterator._first12565); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.text.__CharacterIterator.staticClass = @__class; 
			global::java.text.__CharacterIterator._clone12556 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.clone", "()Ljava/lang/Object;"); 
			global::java.text.__CharacterIterator._next12557 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.next", "()C"); 
			global::java.text.__CharacterIterator._previous12558 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.previous", "()C"); 
			global::java.text.__CharacterIterator._getIndex12559 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.getIndex", "()I"); 
			global::java.text.__CharacterIterator._current12560 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.current", "()C"); 
			global::java.text.__CharacterIterator._setIndex12561 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.setIndex", "(I)C"); 
			global::java.text.__CharacterIterator._getBeginIndex12562 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.getBeginIndex", "()I"); 
			global::java.text.__CharacterIterator._getEndIndex12563 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.getEndIndex", "()I"); 
			global::java.text.__CharacterIterator._last12564 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.last", "()C"); 
			global::java.text.__CharacterIterator._first12565 = @__env.GetMethodID(global::java.text.__CharacterIterator.staticClass, "java.text.CharacterIterator.first", "()C"); 
		} 
	} 
} 
