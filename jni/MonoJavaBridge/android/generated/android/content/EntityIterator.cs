namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface EntityIterator : java.util.Iterator
	{
		void close();
		void reset();
	}

	public partial class EntityIterator_
	{
		public static global::java.lang.Class _class
		{
			get { return __EntityIterator.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __EntityIterator : java.lang.Object, EntityIterator
	{
		internal static global::java.lang.Class staticClass;
		static __EntityIterator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__EntityIterator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.__EntityIterator(@__env);
			}
		}
		internal __EntityIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close1431;
		 void android.content.EntityIterator.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__EntityIterator._close1431);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__EntityIterator.staticClass, global::android.content.__EntityIterator._close1431);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset1432;
		 void android.content.EntityIterator.reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__EntityIterator._reset1432);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__EntityIterator.staticClass, global::android.content.__EntityIterator._reset1432);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasNext1433;
		 bool java.util.Iterator.hasNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.__EntityIterator._hasNext1433);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.__EntityIterator.staticClass, global::android.content.__EntityIterator._hasNext1433);
		}
		internal static global::net.sf.jni4net.jni.MethodId _next1434;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.__EntityIterator._next1434));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.__EntityIterator.staticClass, global::android.content.__EntityIterator._next1434));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove1435;
		 void java.util.Iterator.remove() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__EntityIterator._remove1435);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__EntityIterator.staticClass, global::android.content.__EntityIterator._remove1435);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.__EntityIterator.staticClass = @__class;
			global::android.content.__EntityIterator._close1431 = @__env.GetMethodID(global::android.content.__EntityIterator.staticClass, "android.content.EntityIterator.close", "()V");
			global::android.content.__EntityIterator._reset1432 = @__env.GetMethodID(global::android.content.__EntityIterator.staticClass, "android.content.EntityIterator.reset", "()V");
			global::android.content.__EntityIterator._hasNext1433 = @__env.GetMethodID(global::android.content.__EntityIterator.staticClass, "java.util.Iterator.hasNext", "()Z");
			global::android.content.__EntityIterator._next1434 = @__env.GetMethodID(global::android.content.__EntityIterator.staticClass, "java.util.Iterator.next", "()Ljava/lang/Object;");
			global::android.content.__EntityIterator._remove1435 = @__env.GetMethodID(global::android.content.__EntityIterator.staticClass, "java.util.Iterator.remove", "()V");
		}
	}
}
