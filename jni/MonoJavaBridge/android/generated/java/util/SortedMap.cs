namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface SortedMap : Map
	{
		new global::java.util.Collection values();
		new global::java.util.Set entrySet();
		new global::java.util.Set keySet();
		global::java.util.Comparator comparator();
		global::java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1);
		global::java.util.SortedMap headMap(java.lang.Object arg0);
		global::java.util.SortedMap tailMap(java.lang.Object arg0);
		global::java.lang.Object firstKey();
		global::java.lang.Object lastKey();
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
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.__SortedMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _values13804;
		 global::java.util.Collection java.util.SortedMap.values() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._values13804));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._values13804));
		}
		internal static global::net.sf.jni4net.jni.MethodId _entrySet13805;
		 global::java.util.Set java.util.SortedMap.entrySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._entrySet13805));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._entrySet13805));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keySet13806;
		 global::java.util.Set java.util.SortedMap.keySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._keySet13806));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._keySet13806));
		}
		internal static global::net.sf.jni4net.jni.MethodId _comparator13807;
		 global::java.util.Comparator java.util.SortedMap.comparator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Comparator>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._comparator13807));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Comparator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._comparator13807));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subMap13808;
		 global::java.util.SortedMap java.util.SortedMap.subMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._subMap13808, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._subMap13808, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headMap13809;
		 global::java.util.SortedMap java.util.SortedMap.headMap(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._headMap13809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._headMap13809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _tailMap13810;
		 global::java.util.SortedMap java.util.SortedMap.tailMap(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._tailMap13810, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._tailMap13810, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _firstKey13811;
		 global::java.lang.Object java.util.SortedMap.firstKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._firstKey13811));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._firstKey13811));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lastKey13812;
		 global::java.lang.Object java.util.SortedMap.lastKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._lastKey13812));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._lastKey13812));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get13813;
		 global::java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._get13813, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._get13813, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put13814;
		 global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._put13814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._put13814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13815;
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.__SortedMap._equals13815, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._equals13815, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _values13816;
		 global::java.util.Collection java.util.Map.values() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._values13816));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._values13816));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13817;
		 int java.util.Map.hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.__SortedMap._hashCode13817);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._hashCode13817);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13818;
		 void java.util.Map.clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.__SortedMap._clear13818);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._clear13818);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty13819;
		 bool java.util.Map.isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.__SortedMap._isEmpty13819);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._isEmpty13819);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size13820;
		 int java.util.Map.size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.__SortedMap._size13820);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._size13820);
		}
		internal static global::net.sf.jni4net.jni.MethodId _entrySet13821;
		 global::java.util.Set java.util.Map.entrySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._entrySet13821));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._entrySet13821));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putAll13822;
		 void java.util.Map.putAll(java.util.Map arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.__SortedMap._putAll13822, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._putAll13822, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13823;
		 global::java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._remove13823, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._remove13823, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keySet13824;
		 global::java.util.Set java.util.Map.keySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.__SortedMap._keySet13824));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._keySet13824));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsValue13825;
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.__SortedMap._containsValue13825, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._containsValue13825, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsKey13826;
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.__SortedMap._containsKey13826, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.__SortedMap.staticClass, global::java.util.__SortedMap._containsKey13826, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.__SortedMap.staticClass = @__class;
			global::java.util.__SortedMap._values13804 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.values", "()Ljava/util/Collection;");
			global::java.util.__SortedMap._entrySet13805 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.entrySet", "()Ljava/util/Set;");
			global::java.util.__SortedMap._keySet13806 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.keySet", "()Ljava/util/Set;");
			global::java.util.__SortedMap._comparator13807 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.comparator", "()Ljava/util/Comparator;");
			global::java.util.__SortedMap._subMap13808 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.__SortedMap._headMap13809 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.__SortedMap._tailMap13810 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;");
			global::java.util.__SortedMap._firstKey13811 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.firstKey", "()Ljava/lang/Object;");
			global::java.util.__SortedMap._lastKey13812 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.SortedMap.lastKey", "()Ljava/lang/Object;");
			global::java.util.__SortedMap._get13813 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.__SortedMap._put13814 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.__SortedMap._equals13815 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.equals", "(Ljava/lang/Object;)Z");
			global::java.util.__SortedMap._values13816 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.values", "()Ljava/util/Collection;");
			global::java.util.__SortedMap._hashCode13817 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.hashCode", "()I");
			global::java.util.__SortedMap._clear13818 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.clear", "()V");
			global::java.util.__SortedMap._isEmpty13819 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.isEmpty", "()Z");
			global::java.util.__SortedMap._size13820 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.size", "()I");
			global::java.util.__SortedMap._entrySet13821 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.entrySet", "()Ljava/util/Set;");
			global::java.util.__SortedMap._putAll13822 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.putAll", "(Ljava/util/Map;)V");
			global::java.util.__SortedMap._remove13823 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.__SortedMap._keySet13824 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.keySet", "()Ljava/util/Set;");
			global::java.util.__SortedMap._containsValue13825 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.__SortedMap._containsKey13826 = @__env.GetMethodID(global::java.util.__SortedMap.staticClass, "java.util.Map.containsKey", "(Ljava/lang/Object;)Z");
		}
	}
}
