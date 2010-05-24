namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SortedMap : Map
	{ 
		new java.util.Collection values(); 
		new java.util.Set entrySet(); 
		new java.util.Set keySet(); 
		java.util.Comparator comparator(); 
		java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1); 
		java.util.SortedMap headMap(java.lang.Object arg0); 
		java.util.SortedMap tailMap(java.lang.Object arg0); 
		java.lang.Object firstKey(); 
		java.lang.Object lastKey(); 
	} 

	public partial class SortedMap_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SortedMap.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SortedMap : java.lang.Object, SortedMap
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SortedMap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.__SortedMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.__SortedMap(@__env); 
			} 
		} 
		internal __SortedMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values12973; 
		 java.util.Collection java.util.SortedMap.values() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _values12973)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _values12973)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _entrySet12974; 
		 java.util.Set java.util.SortedMap.entrySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _entrySet12974)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _entrySet12974)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keySet12975; 
		 java.util.Set java.util.SortedMap.keySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _keySet12975)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _keySet12975)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _comparator12976; 
		 java.util.Comparator java.util.SortedMap.comparator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Comparator>(@__env, @__env.CallObjectMethodPtr(this, _comparator12976)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Comparator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _comparator12976)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subMap12977; 
		 java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallObjectMethodPtr(this, _subMap12977, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _subMap12977, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _headMap12978; 
		 java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallObjectMethodPtr(this, _headMap12978, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _headMap12978, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _tailMap12979; 
		 java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallObjectMethodPtr(this, _tailMap12979, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _tailMap12979, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _firstKey12980; 
		 java.lang.Object java.util.SortedMap.firstKey() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _firstKey12980)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _firstKey12980)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lastKey12981; 
		 java.lang.Object java.util.SortedMap.lastKey() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _lastKey12981)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _lastKey12981)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12982; 
		 java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get12982, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _get12982, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12983; 
		 java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _put12983, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _put12983, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12984; 
		 int java.util.Map.hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return @__env.CallIntMethod(this, _hashCode12984); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.__SortedMap.staticClass, _hashCode12984); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12985; 
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return @__env.CallBooleanMethod(this, _equals12985, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.__SortedMap.staticClass, _equals12985, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12986; 
		 void java.util.Map.clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				@__env.CallVoidMethod(this, _clear12986); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.__SortedMap.staticClass, _clear12986); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty12987; 
		 bool java.util.Map.isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return @__env.CallBooleanMethod(this, _isEmpty12987); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.__SortedMap.staticClass, _isEmpty12987); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values12988; 
		 java.util.Collection java.util.Map.values() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, _values12988)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _values12988)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size12989; 
		 int java.util.Map.size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return @__env.CallIntMethod(this, _size12989); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.__SortedMap.staticClass, _size12989); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _entrySet12990; 
		 java.util.Set java.util.Map.entrySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _entrySet12990)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _entrySet12990)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putAll12991; 
		 void java.util.Map.putAll(java.util.Map arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				@__env.CallVoidMethod(this, _putAll12991, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.__SortedMap.staticClass, _putAll12991, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove12992; 
		 java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _remove12992, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _remove12992, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keySet12993; 
		 java.util.Set java.util.Map.keySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _keySet12993)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.__SortedMap.staticClass, _keySet12993)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsValue12994; 
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return @__env.CallBooleanMethod(this, _containsValue12994, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.__SortedMap.staticClass, _containsValue12994, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey12995; 
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.__SortedMap)) 
				return @__env.CallBooleanMethod(this, _containsKey12995, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.__SortedMap.staticClass, _containsKey12995, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.__SortedMap.staticClass = @__class; 
			global::java.util.__SortedMap._values12973 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.values", "()Ljava/util/Collection;"); 
			global::java.util.__SortedMap._entrySet12974 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.entrySet", "()Ljava/util/Set;"); 
			global::java.util.__SortedMap._keySet12975 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.keySet", "()Ljava/util/Set;"); 
			global::java.util.__SortedMap._comparator12976 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.comparator", "()Ljava/util/Comparator;"); 
			global::java.util.__SortedMap._subMap12977 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;"); 
			global::java.util.__SortedMap._headMap12978 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;"); 
			global::java.util.__SortedMap._tailMap12979 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;"); 
			global::java.util.__SortedMap._firstKey12980 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.firstKey", "()Ljava/lang/Object;"); 
			global::java.util.__SortedMap._lastKey12981 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.lastKey", "()Ljava/lang/Object;"); 
			global::java.util.__SortedMap._get12982 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.get", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.__SortedMap._put12983 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.__SortedMap._hashCode12984 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.hashCode", "()I"); 
			global::java.util.__SortedMap._equals12985 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.__SortedMap._clear12986 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.clear", "()V"); 
			global::java.util.__SortedMap._isEmpty12987 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.isEmpty", "()Z"); 
			global::java.util.__SortedMap._values12988 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.values", "()Ljava/util/Collection;"); 
			global::java.util.__SortedMap._size12989 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.size", "()I"); 
			global::java.util.__SortedMap._entrySet12990 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.entrySet", "()Ljava/util/Set;"); 
			global::java.util.__SortedMap._putAll12991 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.putAll", "(Ljava/util/Map;)V"); 
			global::java.util.__SortedMap._remove12992 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.remove", "(Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::java.util.__SortedMap._keySet12993 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.keySet", "()Ljava/util/Set;"); 
			global::java.util.__SortedMap._containsValue12994 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.containsValue", "(Ljava/lang/Object;)Z"); 
			global::java.util.__SortedMap._containsKey12995 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.containsKey", "(Ljava/lang/Object;)Z"); 
		} 
	} 
} 
