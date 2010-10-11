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
		internal static global::MonoJavaBridge.MethodId _clone15057;
		 global::java.lang.Object java.text.CharacterIterator.clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_._clone15057)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._clone15057)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next15058;
		 char java.text.CharacterIterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._next15058);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._next15058);
		}
		internal static global::MonoJavaBridge.MethodId _previous15059;
		 char java.text.CharacterIterator.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._previous15059);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._previous15059);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex15060;
		 int java.text.CharacterIterator.getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getIndex15060);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getIndex15060);
		}
		internal static global::MonoJavaBridge.MethodId _current15061;
		 char java.text.CharacterIterator.current() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._current15061);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._current15061);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex15062;
		 char java.text.CharacterIterator.setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._setIndex15062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._setIndex15062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex15063;
		 int java.text.CharacterIterator.getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getBeginIndex15063);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getBeginIndex15063);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex15064;
		 int java.text.CharacterIterator.getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getEndIndex15064);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getEndIndex15064);
		}
		internal static global::MonoJavaBridge.MethodId _last15065;
		 char java.text.CharacterIterator.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._last15065);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._last15065);
		}
		internal static global::MonoJavaBridge.MethodId _first15066;
		 char java.text.CharacterIterator.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._first15066);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._first15066);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CharacterIterator"));
			global::java.text.CharacterIterator_._clone15057 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.CharacterIterator_._next15058 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "next", "()C");
			global::java.text.CharacterIterator_._previous15059 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "previous", "()C");
			global::java.text.CharacterIterator_._getIndex15060 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.CharacterIterator_._current15061 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "current", "()C");
			global::java.text.CharacterIterator_._setIndex15062 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.CharacterIterator_._getBeginIndex15063 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.CharacterIterator_._getEndIndex15064 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.CharacterIterator_._last15065 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "last", "()C");
			global::java.text.CharacterIterator_._first15066 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "first", "()C");
		}
	}
}
