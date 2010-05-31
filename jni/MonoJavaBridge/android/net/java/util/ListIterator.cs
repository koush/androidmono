namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ListIterator : Iterator
	{ 
		void add(java.lang.Object arg0); 
		new bool hasNext(); 
		new global::java.lang.Object next(); 
		void set(java.lang.Object arg0); 
		new void remove(); 
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
		internal static global::net.sf.jni4net.jni.MethodId _add12891; 
		 void java.util.ListIterator.add(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._add12891, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._add12891, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasNext12892; 
		 bool java.util.ListIterator.hasNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.__ListIterator._hasNext12892); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._hasNext12892); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next12893; 
		 global::java.lang.Object java.util.ListIterator.next() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__ListIterator._next12893)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._next12893)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12894; 
		 void java.util.ListIterator.set(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._set12894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._set12894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12895; 
		 void java.util.ListIterator.remove() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._remove12895); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._remove12895); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _previousIndex12896; 
		 int java.util.ListIterator.previousIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.__ListIterator._previousIndex12896); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._previousIndex12896); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasPrevious12897; 
		 bool java.util.ListIterator.hasPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.__ListIterator._hasPrevious12897); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._hasPrevious12897); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _previous12898; 
		 global::java.lang.Object java.util.ListIterator.previous() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__ListIterator._previous12898)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._previous12898)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextIndex12899; 
		 int java.util.ListIterator.nextIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.__ListIterator._nextIndex12899); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._nextIndex12899); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasNext12900; 
		 bool java.util.Iterator.hasNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.util.__ListIterator._hasNext12900); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._hasNext12900); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next12901; 
		 global::java.lang.Object java.util.Iterator.next() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__ListIterator._next12901)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._next12901)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12902; 
		 void java.util.Iterator.remove() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.util.__ListIterator._remove12902); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__ListIterator.staticClass, global::java.util.__ListIterator._remove12902); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.__ListIterator.staticClass = @__class; 
			global::java.util.__ListIterator._add12891 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.add", "(Ljava/lang/Object;)V"); 
			global::java.util.__ListIterator._hasNext12892 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.hasNext", "()Z"); 
			global::java.util.__ListIterator._next12893 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.next", "()Ljava/lang/Object;"); 
			global::java.util.__ListIterator._set12894 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.set", "(Ljava/lang/Object;)V"); 
			global::java.util.__ListIterator._remove12895 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.remove", "()V"); 
			global::java.util.__ListIterator._previousIndex12896 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.previousIndex", "()I"); 
			global::java.util.__ListIterator._hasPrevious12897 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.hasPrevious", "()Z"); 
			global::java.util.__ListIterator._previous12898 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.previous", "()Ljava/lang/Object;"); 
			global::java.util.__ListIterator._nextIndex12899 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.ListIterator.nextIndex", "()I"); 
			global::java.util.__ListIterator._hasNext12900 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.Iterator.hasNext", "()Z"); 
			global::java.util.__ListIterator._next12901 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.Iterator.next", "()Ljava/lang/Object;"); 
			global::java.util.__ListIterator._remove12902 = @__env.GetMethodID(global::java.util.__ListIterator.staticClass, "java.util.Iterator.remove", "()V"); 
		} 
	} 
} 
