namespace android.provider
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class MediaStore : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static MediaStore()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.provider.MediaStore(@__env);
			}
		}
		internal MediaStore(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Audio : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Audio()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.MediaStore.Audio(@__env);
				}
			}
			internal Audio(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
			public interface AlbumColumns 
			{
			}

			public partial class AlbumColumns_
			{
				public static global::java.lang.Class _class
				{
					get { return __AlbumColumns.staticClass; }
				}
			}

			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class __AlbumColumns : java.lang.Object, AlbumColumns
			{
				internal static global::java.lang.Class staticClass;
				static __AlbumColumns()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.__AlbumColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.__AlbumColumns(@__env);
					}
				}
				internal __AlbumColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.__AlbumColumns.staticClass = @__class;
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public static class AlbumColumnsConstants 
			{
				public static global::java.lang.String ALBUM_ID
				{
					get
					{
						return "album_id";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String NUMBER_OF_SONGS
				{
					get
					{
						return "numsongs";
					}
				}
				public static global::java.lang.String NUMBER_OF_SONGS_FOR_ARTIST
				{
					get
					{
						return "numsongs_by_artist";
					}
				}
				public static global::java.lang.String FIRST_YEAR
				{
					get
					{
						return "minyear";
					}
				}
				public static global::java.lang.String LAST_YEAR
				{
					get
					{
						return "maxyear";
					}
				}
				public static global::java.lang.String ALBUM_KEY
				{
					get
					{
						return "album_key";
					}
				}
				public static global::java.lang.String ALBUM_ART
				{
					get
					{
						return "album_art";
					}
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class Albums : java.lang.Object, BaseColumns, AlbumColumns
			{
				internal static global::java.lang.Class staticClass;
				static Albums()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Albums), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.Albums(@__env);
					}
				}
				internal Albums(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6831;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Albums.staticClass, global::android.provider.MediaStore.Audio.Albums._getContentUri6831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Albums6832;
				public Albums()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Audio.Albums.staticClass, global::android.provider.MediaStore.Audio.Albums._Albums6832, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6833;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6834;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/albums";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/album";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "album_key";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.Albums.staticClass = @__class;
					global::android.provider.MediaStore.Audio.Albums._getContentUri6831 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Albums.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Albums._Albums6832 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Albums.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
			public interface ArtistColumns 
			{
			}

			public partial class ArtistColumns_
			{
				public static global::java.lang.Class _class
				{
					get { return __ArtistColumns.staticClass; }
				}
			}

			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class __ArtistColumns : java.lang.Object, ArtistColumns
			{
				internal static global::java.lang.Class staticClass;
				static __ArtistColumns()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.__ArtistColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.__ArtistColumns(@__env);
					}
				}
				internal __ArtistColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.__ArtistColumns.staticClass = @__class;
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public static class ArtistColumnsConstants 
			{
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ARTIST_KEY
				{
					get
					{
						return "artist_key";
					}
				}
				public static global::java.lang.String NUMBER_OF_ALBUMS
				{
					get
					{
						return "number_of_albums";
					}
				}
				public static global::java.lang.String NUMBER_OF_TRACKS
				{
					get
					{
						return "number_of_tracks";
					}
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class Artists : java.lang.Object, BaseColumns, ArtistColumns
			{
				internal static global::java.lang.Class staticClass;
				static Artists()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Artists), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.Artists(@__env);
					}
				}
				internal Artists(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				[global::net.sf.jni4net.attributes.JavaClassAttribute()]
				public sealed class Albums : java.lang.Object, AlbumColumns
				{
					internal static global::java.lang.Class staticClass;
					static Albums()
					{
						global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Artists.Albums), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
					}
					private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
					{
						public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
						{
							return new global::android.provider.MediaStore.Audio.Artists.Albums(@__env);
						}
					}
					internal Albums(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
					{
					}
					internal static global::net.sf.jni4net.jni.MethodId _getContentUri6835;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
						return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Artists.Albums.staticClass, global::android.provider.MediaStore.Audio.Artists.Albums._getContentUri6835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
					}
					internal static global::net.sf.jni4net.jni.MethodId _Albums6836;
					public Albums()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
					{
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
						@__env.NewObject(android.provider.MediaStore.Audio.Artists.Albums.staticClass, global::android.provider.MediaStore.Audio.Artists.Albums._Albums6836, this);
					}
					private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
					{
						global::android.provider.MediaStore.Audio.Artists.Albums.staticClass = @__class;
						global::android.provider.MediaStore.Audio.Artists.Albums._getContentUri6835 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						global::android.provider.MediaStore.Audio.Artists.Albums._Albums6836 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "<init>", "()V");
					}
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6837;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Artists.staticClass, global::android.provider.MediaStore.Audio.Artists._getContentUri6837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Artists6838;
				public Artists()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Audio.Artists.staticClass, global::android.provider.MediaStore.Audio.Artists._Artists6838, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6839;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6840;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/artists";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/artist";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "artist_key";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.Artists.staticClass = @__class;
					global::android.provider.MediaStore.Audio.Artists._getContentUri6837 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Artists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Artists._Artists6838 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Artists.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
			public interface AudioColumns : MediaColumns
			{
			}

			public partial class AudioColumns_
			{
				public static global::java.lang.Class _class
				{
					get { return __AudioColumns.staticClass; }
				}
			}

			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class __AudioColumns : java.lang.Object, AudioColumns
			{
				internal static global::java.lang.Class staticClass;
				static __AudioColumns()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.__AudioColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.__AudioColumns(@__env);
					}
				}
				internal __AudioColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.__AudioColumns.staticClass = @__class;
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public static class AudioColumnsConstants 
			{
				public static global::java.lang.String TITLE_KEY
				{
					get
					{
						return "title_key";
					}
				}
				public static global::java.lang.String DURATION
				{
					get
					{
						return "duration";
					}
				}
				public static global::java.lang.String BOOKMARK
				{
					get
					{
						return "bookmark";
					}
				}
				public static global::java.lang.String ARTIST_ID
				{
					get
					{
						return "artist_id";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ARTIST_KEY
				{
					get
					{
						return "artist_key";
					}
				}
				public static global::java.lang.String COMPOSER
				{
					get
					{
						return "composer";
					}
				}
				public static global::java.lang.String ALBUM_ID
				{
					get
					{
						return "album_id";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String ALBUM_KEY
				{
					get
					{
						return "album_key";
					}
				}
				public static global::java.lang.String ALBUM_ART
				{
					get
					{
						return "album_art";
					}
				}
				public static global::java.lang.String TRACK
				{
					get
					{
						return "track";
					}
				}
				public static global::java.lang.String YEAR
				{
					get
					{
						return "year";
					}
				}
				public static global::java.lang.String IS_MUSIC
				{
					get
					{
						return "is_music";
					}
				}
				public static global::java.lang.String IS_PODCAST
				{
					get
					{
						return "is_podcast";
					}
				}
				public static global::java.lang.String IS_RINGTONE
				{
					get
					{
						return "is_ringtone";
					}
				}
				public static global::java.lang.String IS_ALARM
				{
					get
					{
						return "is_alarm";
					}
				}
				public static global::java.lang.String IS_NOTIFICATION
				{
					get
					{
						return "is_notification";
					}
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class Genres : java.lang.Object, BaseColumns, GenresColumns
			{
				internal static global::java.lang.Class staticClass;
				static Genres()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Genres), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.Genres(@__env);
					}
				}
				internal Genres(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				[global::net.sf.jni4net.attributes.JavaClassAttribute()]
				public sealed class Members : java.lang.Object, AudioColumns
				{
					internal static global::java.lang.Class staticClass;
					static Members()
					{
						global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Genres.Members), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
					}
					private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
					{
						public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
						{
							return new global::android.provider.MediaStore.Audio.Genres.Members(@__env);
						}
					}
					internal Members(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
					{
					}
					internal static global::net.sf.jni4net.jni.MethodId _getContentUri6841;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
						return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Genres.Members.staticClass, global::android.provider.MediaStore.Audio.Genres.Members._getContentUri6841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
					}
					internal static global::net.sf.jni4net.jni.MethodId _Members6842;
					public Members()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
					{
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
						@__env.NewObject(android.provider.MediaStore.Audio.Genres.Members.staticClass, global::android.provider.MediaStore.Audio.Genres.Members._Members6842, this);
					}
					public static global::java.lang.String CONTENT_DIRECTORY
					{
						get
						{
							return "members";
						}
					}
					public static global::java.lang.String DEFAULT_SORT_ORDER
					{
						get
						{
							return "title_key";
						}
					}
					public static global::java.lang.String AUDIO_ID
					{
						get
						{
							return "audio_id";
						}
					}
					public static global::java.lang.String GENRE_ID
					{
						get
						{
							return "genre_id";
						}
					}
					private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
					{
						global::android.provider.MediaStore.Audio.Genres.Members.staticClass = @__class;
						global::android.provider.MediaStore.Audio.Genres.Members._getContentUri6841 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						global::android.provider.MediaStore.Audio.Genres.Members._Members6842 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "<init>", "()V");
					}
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6843;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Genres.staticClass, global::android.provider.MediaStore.Audio.Genres._getContentUri6843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Genres6844;
				public Genres()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Audio.Genres.staticClass, global::android.provider.MediaStore.Audio.Genres._Genres6844, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6845;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6846;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/genre";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/genre";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "name";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.Genres.staticClass = @__class;
					global::android.provider.MediaStore.Audio.Genres._getContentUri6843 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Genres.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Genres._Genres6844 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Genres.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
			public interface GenresColumns 
			{
			}

			public partial class GenresColumns_
			{
				public static global::java.lang.Class _class
				{
					get { return __GenresColumns.staticClass; }
				}
			}

			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class __GenresColumns : java.lang.Object, GenresColumns
			{
				internal static global::java.lang.Class staticClass;
				static __GenresColumns()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.__GenresColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.__GenresColumns(@__env);
					}
				}
				internal __GenresColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.__GenresColumns.staticClass = @__class;
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public static class GenresColumnsConstants 
			{
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class Media : java.lang.Object, AudioColumns
			{
				internal static global::java.lang.Class staticClass;
				static Media()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Media), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.Media(@__env);
					}
				}
				internal Media(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6847;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._getContentUri6847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUriForPath6848;
				public static global::android.net.Uri getContentUriForPath(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._getContentUriForPath6848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Media6849;
				public Media()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._Media6849, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6850;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6851;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/audio";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "title_key";
					}
				}
				public static global::java.lang.String RECORD_SOUND_ACTION
				{
					get
					{
						return "android.provider.MediaStore.RECORD_SOUND";
					}
				}
				public static global::java.lang.String EXTRA_MAX_BYTES
				{
					get
					{
						return "android.provider.MediaStore.extra.MAX_BYTES";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.Media.staticClass = @__class;
					global::android.provider.MediaStore.Audio.Media._getContentUri6847 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Media._getContentUriForPath6848 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUriForPath", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Media._Media6849 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Media.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class Playlists : java.lang.Object, BaseColumns, PlaylistsColumns
			{
				internal static global::java.lang.Class staticClass;
				static Playlists()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Playlists), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.Playlists(@__env);
					}
				}
				internal Playlists(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				[global::net.sf.jni4net.attributes.JavaClassAttribute()]
				public sealed class Members : java.lang.Object, AudioColumns
				{
					internal static global::java.lang.Class staticClass;
					static Members()
					{
						global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.Playlists.Members), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
					}
					private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
					{
						public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
						{
							return new global::android.provider.MediaStore.Audio.Playlists.Members(@__env);
						}
					}
					internal Members(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
					{
					}
					internal static global::net.sf.jni4net.jni.MethodId _getContentUri6852;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
						return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._getContentUri6852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
					}
					internal static global::net.sf.jni4net.jni.MethodId _moveItem6853;
					public static bool moveItem(android.content.ContentResolver arg0, long arg1, int arg2, int arg3) 
					{
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
						return @__env.CallStaticBooleanMethod(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._moveItem6853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
					}
					internal static global::net.sf.jni4net.jni.MethodId _Members6854;
					public Members()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
					{
						global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
						@__env.NewObject(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._Members6854, this);
					}
					public static global::java.lang.String _ID
					{
						get
						{
							return "_id";
						}
					}
					public static global::java.lang.String CONTENT_DIRECTORY
					{
						get
						{
							return "members";
						}
					}
					public static global::java.lang.String AUDIO_ID
					{
						get
						{
							return "audio_id";
						}
					}
					public static global::java.lang.String PLAYLIST_ID
					{
						get
						{
							return "playlist_id";
						}
					}
					public static global::java.lang.String PLAY_ORDER
					{
						get
						{
							return "play_order";
						}
					}
					public static global::java.lang.String DEFAULT_SORT_ORDER
					{
						get
						{
							return "play_order";
						}
					}
					private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
					{
						global::android.provider.MediaStore.Audio.Playlists.Members.staticClass = @__class;
						global::android.provider.MediaStore.Audio.Playlists.Members._getContentUri6852 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						global::android.provider.MediaStore.Audio.Playlists.Members._moveItem6853 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "moveItem", "(Landroid/content/ContentResolver;JII)Z");
						global::android.provider.MediaStore.Audio.Playlists.Members._Members6854 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "<init>", "()V");
					}
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6855;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.Playlists.staticClass, global::android.provider.MediaStore.Audio.Playlists._getContentUri6855, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Playlists6856;
				public Playlists()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Audio.Playlists.staticClass, global::android.provider.MediaStore.Audio.Playlists._Playlists6856, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6857;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6858;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/playlist";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/playlist";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "name";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.Playlists.staticClass = @__class;
					global::android.provider.MediaStore.Audio.Playlists._getContentUri6855 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.Playlists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Playlists._Playlists6856 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.Playlists.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
			public interface PlaylistsColumns 
			{
			}

			public partial class PlaylistsColumns_
			{
				public static global::java.lang.Class _class
				{
					get { return __PlaylistsColumns.staticClass; }
				}
			}

			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class __PlaylistsColumns : java.lang.Object, PlaylistsColumns
			{
				internal static global::java.lang.Class staticClass;
				static __PlaylistsColumns()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Audio.__PlaylistsColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Audio.__PlaylistsColumns(@__env);
					}
				}
				internal __PlaylistsColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Audio.__PlaylistsColumns.staticClass = @__class;
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public static class PlaylistsColumnsConstants 
			{
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String DATE_ADDED
				{
					get
					{
						return "date_added";
					}
				}
				public static global::java.lang.String DATE_MODIFIED
				{
					get
					{
						return "date_modified";
					}
				}
			}
			internal static global::net.sf.jni4net.jni.MethodId _keyFor6859;
			public static global::java.lang.String keyFor(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Audio.staticClass, global::android.provider.MediaStore.Audio._keyFor6859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Audio6860;
			public Audio()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.provider.MediaStore.Audio.staticClass, global::android.provider.MediaStore.Audio._Audio6860, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.MediaStore.Audio.staticClass = @__class;
				global::android.provider.MediaStore.Audio._keyFor6859 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Audio.staticClass, "keyFor", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.provider.MediaStore.Audio._Audio6860 = @__env.GetMethodID(global::android.provider.MediaStore.Audio.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Images : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Images()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Images), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.MediaStore.Images(@__env);
				}
			}
			internal Images(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
			public interface ImageColumns : MediaColumns
			{
			}

			public partial class ImageColumns_
			{
				public static global::java.lang.Class _class
				{
					get { return __ImageColumns.staticClass; }
				}
			}

			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class __ImageColumns : java.lang.Object, ImageColumns
			{
				internal static global::java.lang.Class staticClass;
				static __ImageColumns()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Images.__ImageColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Images.__ImageColumns(@__env);
					}
				}
				internal __ImageColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Images.__ImageColumns.staticClass = @__class;
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public static class ImageColumnsConstants 
			{
				public static global::java.lang.String DESCRIPTION
				{
					get
					{
						return "description";
					}
				}
				public static global::java.lang.String PICASA_ID
				{
					get
					{
						return "picasa_id";
					}
				}
				public static global::java.lang.String IS_PRIVATE
				{
					get
					{
						return "isprivate";
					}
				}
				public static global::java.lang.String LATITUDE
				{
					get
					{
						return "latitude";
					}
				}
				public static global::java.lang.String LONGITUDE
				{
					get
					{
						return "longitude";
					}
				}
				public static global::java.lang.String DATE_TAKEN
				{
					get
					{
						return "datetaken";
					}
				}
				public static global::java.lang.String ORIENTATION
				{
					get
					{
						return "orientation";
					}
				}
				public static global::java.lang.String MINI_THUMB_MAGIC
				{
					get
					{
						return "mini_thumb_magic";
					}
				}
				public static global::java.lang.String BUCKET_ID
				{
					get
					{
						return "bucket_id";
					}
				}
				public static global::java.lang.String BUCKET_DISPLAY_NAME
				{
					get
					{
						return "bucket_display_name";
					}
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class Media : java.lang.Object, ImageColumns
			{
				internal static global::java.lang.Class staticClass;
				static Media()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Images.Media), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Images.Media(@__env);
					}
				}
				internal Media(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::net.sf.jni4net.jni.MethodId _query6861;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._query6861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _query6862;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._query6862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _query6863;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._query6863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getBitmap6864;
				public static global::android.graphics.Bitmap getBitmap(android.content.ContentResolver arg0, android.net.Uri arg1) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._getBitmap6864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6865;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._getContentUri6865, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _insertImage6866;
				public static global::java.lang.String insertImage(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._insertImage6866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _insertImage6867;
				public static global::java.lang.String insertImage(android.content.ContentResolver arg0, android.graphics.Bitmap arg1, java.lang.String arg2, java.lang.String arg3) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._insertImage6867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Media6868;
				public Media()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._Media6868, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6869;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6870;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/image";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "bucket_display_name";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Images.Media.staticClass = @__class;
					global::android.provider.MediaStore.Images.Media._query6861 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Media._query6862 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Media._query6863 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Media._getBitmap6864 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "getBitmap", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Images.Media._getContentUri6865 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Images.Media._insertImage6866 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
					global::android.provider.MediaStore.Images.Media._insertImage6867 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
					global::android.provider.MediaStore.Images.Media._Media6868 = @__env.GetMethodID(global::android.provider.MediaStore.Images.Media.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public class Thumbnails : java.lang.Object, BaseColumns
			{
				internal static global::java.lang.Class staticClass;
				static Thumbnails()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Images.Thumbnails), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Images.Thumbnails(@__env);
					}
				}
				protected Thumbnails(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::net.sf.jni4net.jni.MethodId _query6871;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._query6871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getThumbnail6872;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, long arg2, int arg3, android.graphics.BitmapFactory.Options arg4) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._getThumbnail6872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getThumbnail6873;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._getThumbnail6873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6874;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._getContentUri6874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _queryMiniThumbnails6875;
				public static global::android.database.Cursor queryMiniThumbnails(android.content.ContentResolver arg0, android.net.Uri arg1, int arg2, java.lang.String[] arg3) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnails6875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _queryMiniThumbnail6876;
				public static global::android.database.Cursor queryMiniThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, java.lang.String[] arg3) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnail6876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _cancelThumbnailRequest6877;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1, long arg2) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest6877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				}
				internal static global::net.sf.jni4net.jni.MethodId _cancelThumbnailRequest6878;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest6878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Thumbnails6879;
				public Thumbnails()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._Thumbnails6879, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6880;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6881;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "image_id ASC";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String IMAGE_ID
				{
					get
					{
						return "image_id";
					}
				}
				public static global::java.lang.String KIND
				{
					get
					{
						return "kind";
					}
				}
				public static int MINI_KIND
				{
					get
					{
						return 1;
					}
				}
				public static int FULL_SCREEN_KIND
				{
					get
					{
						return 2;
					}
				}
				public static int MICRO_KIND
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String THUMB_DATA
				{
					get
					{
						return "thumb_data";
					}
				}
				public static global::java.lang.String WIDTH
				{
					get
					{
						return "width";
					}
				}
				public static global::java.lang.String HEIGHT
				{
					get
					{
						return "height";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Images.Thumbnails.staticClass = @__class;
					global::android.provider.MediaStore.Images.Thumbnails._query6871 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Thumbnails._getThumbnail6872 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Images.Thumbnails._getThumbnail6873 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Images.Thumbnails._getContentUri6874 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnails6875 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnails", "(Landroid/content/ContentResolver;Landroid/net/Uri;I[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnail6876 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnail", "(Landroid/content/ContentResolver;JI[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest6877 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V");
					global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest6878 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V");
					global::android.provider.MediaStore.Images.Thumbnails._Thumbnails6879 = @__env.GetMethodID(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "<init>", "()V");
				}
			}
			internal static global::net.sf.jni4net.jni.MethodId _Images6882;
			public Images()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.provider.MediaStore.Images.staticClass, global::android.provider.MediaStore.Images._Images6882, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.MediaStore.Images.staticClass = @__class;
				global::android.provider.MediaStore.Images._Images6882 = @__env.GetMethodID(global::android.provider.MediaStore.Images.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface MediaColumns : BaseColumns
		{
		}

		public partial class MediaColumns_
		{
			public static global::java.lang.Class _class
			{
				get { return __MediaColumns.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __MediaColumns : java.lang.Object, MediaColumns
		{
			internal static global::java.lang.Class staticClass;
			static __MediaColumns()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.__MediaColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.MediaStore.__MediaColumns(@__env);
				}
			}
			internal __MediaColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.MediaStore.__MediaColumns.staticClass = @__class;
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public static class MediaColumnsConstants 
		{
			public static global::java.lang.String DATA
			{
				get
				{
					return "_data";
				}
			}
			public static global::java.lang.String SIZE
			{
				get
				{
					return "_size";
				}
			}
			public static global::java.lang.String DISPLAY_NAME
			{
				get
				{
					return "_display_name";
				}
			}
			public static global::java.lang.String TITLE
			{
				get
				{
					return "title";
				}
			}
			public static global::java.lang.String DATE_ADDED
			{
				get
				{
					return "date_added";
				}
			}
			public static global::java.lang.String DATE_MODIFIED
			{
				get
				{
					return "date_modified";
				}
			}
			public static global::java.lang.String MIME_TYPE
			{
				get
				{
					return "mime_type";
				}
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Video : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Video()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Video), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.MediaStore.Video(@__env);
				}
			}
			internal Video(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class Media : java.lang.Object, VideoColumns
			{
				internal static global::java.lang.Class staticClass;
				static Media()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Video.Media), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Video.Media(@__env);
					}
				}
				internal Media(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6883;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.Media.staticClass, global::android.provider.MediaStore.Video.Media._getContentUri6883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Media6884;
				public Media()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Video.Media.staticClass, global::android.provider.MediaStore.Video.Media._Media6884, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6885;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6886;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/video";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "title";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Video.Media.staticClass = @__class;
					global::android.provider.MediaStore.Video.Media._getContentUri6883 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Video.Media._Media6884 = @__env.GetMethodID(global::android.provider.MediaStore.Video.Media.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public class Thumbnails : java.lang.Object, BaseColumns
			{
				internal static global::java.lang.Class staticClass;
				static Thumbnails()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Video.Thumbnails), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Video.Thumbnails(@__env);
					}
				}
				protected Thumbnails(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::net.sf.jni4net.jni.MethodId _getThumbnail6887;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._getThumbnail6887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getThumbnail6888;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, long arg2, int arg3, android.graphics.BitmapFactory.Options arg4) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._getThumbnail6888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _getContentUri6889;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._getContentUri6889, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				}
				internal static global::net.sf.jni4net.jni.MethodId _cancelThumbnailRequest6890;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest6890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				}
				internal static global::net.sf.jni4net.jni.MethodId _cancelThumbnailRequest6891;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1, long arg2) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest6891, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				}
				internal static global::net.sf.jni4net.jni.MethodId _Thumbnails6892;
				public Thumbnails()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
					@__env.NewObject(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._Thumbnails6892, this);
				}
				internal static global::net.sf.jni4net.jni.FieldId _INTERNAL_CONTENT_URI6893;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::net.sf.jni4net.jni.FieldId _EXTERNAL_CONTENT_URI6894;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "video_id ASC";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String VIDEO_ID
				{
					get
					{
						return "video_id";
					}
				}
				public static global::java.lang.String KIND
				{
					get
					{
						return "kind";
					}
				}
				public static int MINI_KIND
				{
					get
					{
						return 1;
					}
				}
				public static int FULL_SCREEN_KIND
				{
					get
					{
						return 2;
					}
				}
				public static int MICRO_KIND
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String WIDTH
				{
					get
					{
						return "width";
					}
				}
				public static global::java.lang.String HEIGHT
				{
					get
					{
						return "height";
					}
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Video.Thumbnails.staticClass = @__class;
					global::android.provider.MediaStore.Video.Thumbnails._getThumbnail6887 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Video.Thumbnails._getThumbnail6888 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Video.Thumbnails._getContentUri6889 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest6890 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V");
					global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest6891 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V");
					global::android.provider.MediaStore.Video.Thumbnails._Thumbnails6892 = @__env.GetMethodID(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "<init>", "()V");
				}
			}
			[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
			public interface VideoColumns : MediaColumns
			{
			}

			public partial class VideoColumns_
			{
				public static global::java.lang.Class _class
				{
					get { return __VideoColumns.staticClass; }
				}
			}

			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public sealed class __VideoColumns : java.lang.Object, VideoColumns
			{
				internal static global::java.lang.Class staticClass;
				static __VideoColumns()
				{
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.MediaStore.Video.__VideoColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
				}
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
				{
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
					{
						return new global::android.provider.MediaStore.Video.__VideoColumns(@__env);
					}
				}
				internal __VideoColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
				{
					global::android.provider.MediaStore.Video.__VideoColumns.staticClass = @__class;
				}
			}
			[global::net.sf.jni4net.attributes.JavaClassAttribute()]
			public static class VideoColumnsConstants 
			{
				public static global::java.lang.String DURATION
				{
					get
					{
						return "duration";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String RESOLUTION
				{
					get
					{
						return "resolution";
					}
				}
				public static global::java.lang.String DESCRIPTION
				{
					get
					{
						return "description";
					}
				}
				public static global::java.lang.String IS_PRIVATE
				{
					get
					{
						return "isprivate";
					}
				}
				public static global::java.lang.String TAGS
				{
					get
					{
						return "tags";
					}
				}
				public static global::java.lang.String CATEGORY
				{
					get
					{
						return "category";
					}
				}
				public static global::java.lang.String LANGUAGE
				{
					get
					{
						return "language";
					}
				}
				public static global::java.lang.String LATITUDE
				{
					get
					{
						return "latitude";
					}
				}
				public static global::java.lang.String LONGITUDE
				{
					get
					{
						return "longitude";
					}
				}
				public static global::java.lang.String DATE_TAKEN
				{
					get
					{
						return "datetaken";
					}
				}
				public static global::java.lang.String MINI_THUMB_MAGIC
				{
					get
					{
						return "mini_thumb_magic";
					}
				}
				public static global::java.lang.String BUCKET_ID
				{
					get
					{
						return "bucket_id";
					}
				}
				public static global::java.lang.String BUCKET_DISPLAY_NAME
				{
					get
					{
						return "bucket_display_name";
					}
				}
				public static global::java.lang.String BOOKMARK
				{
					get
					{
						return "bookmark";
					}
				}
			}
			internal static global::net.sf.jni4net.jni.MethodId _query6895;
			public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.Video.staticClass, global::android.provider.MediaStore.Video._query6895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Video6896;
			public Video()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.provider.MediaStore.Video.staticClass, global::android.provider.MediaStore.Video._Video6896, this);
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "_display_name";
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.MediaStore.Video.staticClass = @__class;
				global::android.provider.MediaStore.Video._query6895 = @__env.GetStaticMethodID(global::android.provider.MediaStore.Video.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
				global::android.provider.MediaStore.Video._Video6896 = @__env.GetMethodID(global::android.provider.MediaStore.Video.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMediaScannerUri6897;
		public static global::android.net.Uri getMediaScannerUri() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.MediaStore.staticClass, global::android.provider.MediaStore._getMediaScannerUri6897));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MediaStore6898;
		public MediaStore()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.provider.MediaStore.staticClass, global::android.provider.MediaStore._MediaStore6898, this);
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "media";
			}
		}
		public static global::java.lang.String INTENT_ACTION_MUSIC_PLAYER
		{
			get
			{
				return "android.intent.action.MUSIC_PLAYER";
			}
		}
		public static global::java.lang.String INTENT_ACTION_MEDIA_SEARCH
		{
			get
			{
				return "android.intent.action.MEDIA_SEARCH";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_ARTIST
		{
			get
			{
				return "android.intent.extra.artist";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_ALBUM
		{
			get
			{
				return "android.intent.extra.album";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_TITLE
		{
			get
			{
				return "android.intent.extra.title";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_FOCUS
		{
			get
			{
				return "android.intent.extra.focus";
			}
		}
		public static global::java.lang.String EXTRA_SCREEN_ORIENTATION
		{
			get
			{
				return "android.intent.extra.screenOrientation";
			}
		}
		public static global::java.lang.String EXTRA_FULL_SCREEN
		{
			get
			{
				return "android.intent.extra.fullScreen";
			}
		}
		public static global::java.lang.String EXTRA_SHOW_ACTION_ICONS
		{
			get
			{
				return "android.intent.extra.showActionIcons";
			}
		}
		public static global::java.lang.String EXTRA_FINISH_ON_COMPLETION
		{
			get
			{
				return "android.intent.extra.finishOnCompletion";
			}
		}
		public static global::java.lang.String INTENT_ACTION_STILL_IMAGE_CAMERA
		{
			get
			{
				return "android.media.action.STILL_IMAGE_CAMERA";
			}
		}
		public static global::java.lang.String INTENT_ACTION_VIDEO_CAMERA
		{
			get
			{
				return "android.media.action.VIDEO_CAMERA";
			}
		}
		public static global::java.lang.String ACTION_IMAGE_CAPTURE
		{
			get
			{
				return "android.media.action.IMAGE_CAPTURE";
			}
		}
		public static global::java.lang.String ACTION_VIDEO_CAPTURE
		{
			get
			{
				return "android.media.action.VIDEO_CAPTURE";
			}
		}
		public static global::java.lang.String EXTRA_VIDEO_QUALITY
		{
			get
			{
				return "android.intent.extra.videoQuality";
			}
		}
		public static global::java.lang.String EXTRA_SIZE_LIMIT
		{
			get
			{
				return "android.intent.extra.sizeLimit";
			}
		}
		public static global::java.lang.String EXTRA_DURATION_LIMIT
		{
			get
			{
				return "android.intent.extra.durationLimit";
			}
		}
		public static global::java.lang.String EXTRA_OUTPUT
		{
			get
			{
				return "output";
			}
		}
		public static global::java.lang.String UNKNOWN_STRING
		{
			get
			{
				return "<unknown>";
			}
		}
		public static global::java.lang.String MEDIA_SCANNER_VOLUME
		{
			get
			{
				return "volume";
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.provider.MediaStore.staticClass = @__class;
			global::android.provider.MediaStore._getMediaScannerUri6897 = @__env.GetStaticMethodID(global::android.provider.MediaStore.staticClass, "getMediaScannerUri", "()Landroid/net/Uri;");
			global::android.provider.MediaStore._MediaStore6898 = @__env.GetMethodID(global::android.provider.MediaStore.staticClass, "<init>", "()V");
		}
	}
}
