namespace java.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.text.CharacterIterator_))]
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

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.CharacterIterator))]
	public sealed partial class CharacterIterator_ : java.lang.Object, CharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharacterIterator_()
		{
			InitJNI();
		}
		internal CharacterIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone19392;
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_._clone19392)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._clone19392)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next19393;
		 char java.text.CharacterIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._next19393);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._next19393);
		}
		internal static global::MonoJavaBridge.MethodId _previous19394;
		 char java.text.CharacterIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._previous19394);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._previous19394);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex19395;
		 int java.text.CharacterIterator.getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getIndex19395);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getIndex19395);
		}
		internal static global::MonoJavaBridge.MethodId _current19396;
		 char java.text.CharacterIterator.current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._current19396);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._current19396);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex19397;
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._setIndex19397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._setIndex19397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex19398;
		 int java.text.CharacterIterator.getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getBeginIndex19398);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getBeginIndex19398);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex19399;
		 int java.text.CharacterIterator.getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getEndIndex19399);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getEndIndex19399);
		}
		internal static global::MonoJavaBridge.MethodId _last19400;
		 char java.text.CharacterIterator.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._last19400);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._last19400);
		}
		internal static global::MonoJavaBridge.MethodId _first19401;
		 char java.text.CharacterIterator.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._first19401);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._first19401);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CharacterIterator"));
			global::java.text.CharacterIterator_._clone19392 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.CharacterIterator_._next19393 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "next", "()C");
			global::java.text.CharacterIterator_._previous19394 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "previous", "()C");
			global::java.text.CharacterIterator_._getIndex19395 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.CharacterIterator_._current19396 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "current", "()C");
			global::java.text.CharacterIterator_._setIndex19397 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.CharacterIterator_._getBeginIndex19398 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.CharacterIterator_._getEndIndex19399 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.CharacterIterator_._last19400 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "last", "()C");
			global::java.text.CharacterIterator_._first19401 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "first", "()C");
		}
	}
}
