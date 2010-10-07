namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ListIterator : Iterator
	{
		void add(java.lang.Object arg0);
		new bool hasNext();
		new global::java.lang.Object next();
		new void remove();
		void set(java.lang.Object arg0);
		int previousIndex();
		bool hasPrevious();
		global::java.lang.Object previous();
		int nextIndex();
	}

	public partial class ListIterator_
	{
		public static global::java.lang.Class _class
		{
			get { return __ListIterator.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ListIterator : java.lang.Object, ListIterator
	{
		internal static global::java.lang.Class staticClass;
		static __ListIterator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.__ListIterator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.__ListIterator(@__env);
			}
		}
		internal __ListIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _add13722;
		 void java.util.ListIterator.add(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._add13722, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._add13722, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasNext13723;
		 bool java.util.ListIterator.hasNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.__ListIterator._hasNext13723);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._hasNext13723);
		}
		internal static global::net.sf.jni4net.jni.MethodId _next13724;
		 global::java.lang.Object java.util.ListIterator.next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__ListIterator._next13724));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._next13724));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13725;
		 void java.util.ListIterator.remove() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._remove13725);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._remove13725);
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13726;
		 void java.util.ListIterator.set(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._set13726, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._set13726, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _previousIndex13727;
		 int java.util.ListIterator.previousIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.__ListIterator._previousIndex13727);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._previousIndex13727);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasPrevious13728;
		 bool java.util.ListIterator.hasPrevious() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.__ListIterator._hasPrevious13728);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._hasPrevious13728);
		}
		internal static global::net.sf.jni4net.jni.MethodId _previous13729;
		 global::java.lang.Object java.util.ListIterator.previous() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__ListIterator._previous13729));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._previous13729));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextIndex13730;
		 int java.util.ListIterator.nextIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.__ListIterator._nextIndex13730);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._nextIndex13730);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasNext13731;
		 bool java.util.Iterator.hasNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.__ListIterator._hasNext13731);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._hasNext13731);
		}
		internal static global::net.sf.jni4net.jni.MethodId _next13732;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__ListIterator._next13732));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._next13732));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13733;
		 void java.util.Iterator.remove() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._remove13733);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._remove13733);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.__ListIterator.staticClass = @__class;
			global::java.util.__ListIterator._add13722 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.add", "(Ljava/lang/Object;)V");
			global::java.util.__ListIterator._hasNext13723 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.hasNext", "()Z");
			global::java.util.__ListIterator._next13724 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.next", "()Ljava/lang/Object;");
			global::java.util.__ListIterator._remove13725 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.remove", "()V");
			global::java.util.__ListIterator._set13726 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.set", "(Ljava/lang/Object;)V");
			global::java.util.__ListIterator._previousIndex13727 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.previousIndex", "()I");
			global::java.util.__ListIterator._hasPrevious13728 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.hasPrevious", "()Z");
			global::java.util.__ListIterator._previous13729 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.previous", "()Ljava/lang/Object;");
			global::java.util.__ListIterator._nextIndex13730 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.nextIndex", "()I");
			global::java.util.__ListIterator._hasNext13731 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.Iterator.hasNext", "()Z");
			global::java.util.__ListIterator._next13732 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.Iterator.next", "()Ljava/lang/Object;");
			global::java.util.__ListIterator._remove13733 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.Iterator.remove", "()V");
		}
	}
}
